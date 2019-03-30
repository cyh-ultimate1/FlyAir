using Dapper;
using FlyAir.Data.IRepositories;
using FlyAir.Hubs;
using FlyAir.Models;
using FlyAir.Models.BookingModels;
using FlyAir.Models.FlightModels;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;

namespace FlyAir.Data.Repositories
{
    public class BookingRepo : IBookingRepo
    {
        private readonly IConfiguration _config;
        private SqlTableDependency<Booking> _tableDependency;
        private readonly IHubContext<BookingHub> _bookingHub;
        private readonly IGlobalRepo _globalRepo;

        public BookingRepo(IConfiguration config, IHubContext<BookingHub> bookingHub, IGlobalRepo globalRepo)
        {
            _config = config;
            _bookingHub = bookingHub;
            _globalRepo = globalRepo;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString(commonName.defaultConn));
            }
        }

        public async Task<int> AddBooking(Booking booking, string memberId = null)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = null;
                    var result = 0;
                    conn.Open();
                    if (booking.ReturnFlight != null)
                    {
                        sQuery = "INSERT INTO Bookings (DateTimeCreated, GoFlightId, ReturnFlightId, MemberId) VALUES (GETDATE(), @GoFlightId, @ReturnFlightId, @MemberId)" +
                        "SELECT CAST(SCOPE_IDENTITY() as int);";
                        result = await conn.QuerySingleAsync<int>(sQuery, new { GoFlightId = booking.GoFlightId, ReturnFlightId = booking.ReturnFlightId, MemberId = memberId });
                    }
                    else
                    {
                        sQuery = "INSERT INTO Bookings (DateTimeCreated, GoFlightId, MemberId) VALUES (GETDATE(), @GoFlightId, @MemberId)" +
                        "SELECT CAST(SCOPE_IDENTITY() as int);";
                        result = await conn.QuerySingleAsync<int>(sQuery, new { GoFlightId = booking.GoFlightId, MemberId = memberId });
                    }
                    using (var log = new LoggerConfiguration().MinimumLevel.Debug()
                                        .WriteTo.File("..\\fileDirectory\\logging.txt")
                                        //.WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Information)
                                        .CreateLogger())
                    {
                        log.Information("New booking added!");
                    }
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public async Task<int> AddBookingGuests(BookingNonMember booking, int bookingId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "INSERT INTO BookingNonMember (Name, Age, BookingID, IsMainPayer, DateOfBirth, PassportNum) VALUES (@Name, @Age, @BookingID, @IsMainPayer, @DateOfBirth, @PassportNum)" +
                        "SELECT CAST(SCOPE_IDENTITY() as int)";
                    conn.Open();
                    var result = conn.QueryAsync<int>(sQuery, new { Name = booking.Name, Age = booking.Age, BookingID = bookingId, IsMainPayer = booking.IsMainPayer, DateOfBirth = booking.DateOfBirth, PassportNum = booking.PassportNum }).Result.Single();
                    return result;
                }
                catch (Exception ex)
                {
                    _globalRepo.SaveExceptionToLogFile(ex);
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public async Task<IEnumerable<Booking>> GetMemberBookings(string userId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM Bookings WHERE MemberId = @MemberId";
                    conn.Open();
                    var result = await conn.QueryAsync<Booking>(sQuery, new { MemberId = userId });
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public async Task<IEnumerable<Booking>> GetMemberBookingsFlight(string userId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM Bookings WHERE MemberId = @MemberId";
                    conn.Open();
                    var result = await conn.QueryAsync<Booking>(sQuery, new { MemberId = userId });
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public async Task<Booking> GetBookingById (int bookingId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + Booking.tableName + " WHERE Id = @Id";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<Booking>(sQuery, new { Id = bookingId });
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public async Task<BookingVM> GetBookingWGuestsById(int bookingId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + Booking.tableName + " WHERE Id = @Id;";
                    string sQuery2 = "SELECT * FROM " + BookingNonMember.tableName + " WHERE BookingID = @Id;";
                    conn.Open();
                    var results = await conn.QueryMultipleAsync(sQuery + sQuery2, new { Id = bookingId });

                    var booking = results.Read<Booking>().Single();
                    var guests = results.Read<BookingNonMember>();
                    var result = new BookingVM
                    {
                        Booking = booking,
                        BookingNonMembers = guests.ToList()
                    };
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        public async Task<Location> GetLocById(int id)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + Location.tableName + " WHERE Id = @Id";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<Location>(sQuery, new { Id = id });
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //isGoOrReturn = true means GoFlight, else ReturnFlight
        public async Task<IEnumerable<string>> GetSeatsTakenByFlightId(int flightId, bool isGoOrReturn)
        {
            string seatNumDigitStr = "", seatNumLetterStr = "", flightIdStr = "";
            if (isGoOrReturn)
            {
                flightIdStr = "GoFlightId";
                seatNumDigitStr = "SeatNumDigitGoFlight";
                seatNumLetterStr = "SeatNumLetterGoFlight";
            }
            else
            {
                flightIdStr = "ReturnFlightId";
                seatNumDigitStr = "SeatNumDigitReturnFlight";
                seatNumLetterStr = "SeatNumLetterReturnFlight";
            }
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT LTRIM(STR(" + seatNumDigitStr + "))+" + seatNumLetterStr + " FROM " + BookingNonMember.tableName + " WHERE BookingID IN (SELECT ID FROM " + Booking.tableName + " WHERE " + flightIdStr +
                        " = @FlightId) AND ( " + seatNumDigitStr + " IS NOT NULL OR " + seatNumLetterStr + " IS NOT NULL) ORDER BY " + seatNumDigitStr + " ASC, " + seatNumLetterStr + " ASC;";
                    conn.Open();
                    var result = await conn.QueryAsync<string>(sQuery, new { FlightId = flightId });
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }

        public async Task<int> UpdateGuestsSeats(BookingNonMember input)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "UPDATE BookingNonMember SET SeatNumDigitGoFlight = @SeatNumDigitGoFlight, SeatNumLetterGoFlight = @SeatNumLetterGoFlight";
                    if (input.SeatNumDigitReturnFlight != null)
                    {
                        sQuery += ", SeatNumDigitReturnFlight = @SeatNumDigitReturnFlight, SeatNumLetterReturnFlight = @SeatNumLetterReturnFlight";
                    }
                    sQuery += "   WHERE BookingID = @BookingID AND ID = @ID; ";
                    conn.Open();
                    var result = await conn.ExecuteAsync(sQuery, new { SeatNumDigitGoFlight = input.SeatNumDigitGoFlight, SeatNumLetterGoFlight = input.SeatNumLetterGoFlight, SeatNumDigitReturnFlight = input.SeatNumDigitReturnFlight, SeatNumLetterReturnFlight = input.SeatNumLetterReturnFlight, BookingID=input.BookingID, ID = input.ID });
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public async Task<int> UpdateHasCheckedIn(int bookingId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "UPDATE Bookings SET HasCheckedIn = 'true' WHERE ID = @Id; ";
                    conn.Open();
                    var result = await conn.ExecuteAsync(sQuery, new { Id = bookingId });
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        #region updateSubscription

        public void subscribeBookingAdd()
        {
            using (SqlConnection connection = new SqlConnection(_config.GetConnectionString(commonName.defaultConn)))
            {
                try
                {
                    var cs = _config.GetConnectionString(commonName.defaultConn);
                    _tableDependency = new SqlTableDependency<Booking>(cs, "Bookings", null, null, null, null, DmlTriggerType.Insert);
                    _tableDependency.OnChanged += Changed;
                    //_tableDependency.OnError += TableDependency_OnError;
                    _tableDependency.Start();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Changed(object sender, RecordChangedEventArgs<Booking> e)
        {
            if (e.ChangeType != ChangeType.None)
            {
                _bookingHub.Clients.All.SendAsync("subsNewAdd", "Someone just booked.");
            }
        }

        #endregion

    }
}
