using Dapper;
using FlyAir.Data.IRepositories;
using FlyAir.Models;
using FlyAir.Models.FlightModels;
using FlyAir.Models.IdentityEntities;
using FlyAir.Models.SearchModels;
using FlyAir.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.Repositories
{
    public class FlightRepo : IFlightRepo
    {
        private readonly IConfiguration _config;

        public FlightRepo(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString(commonName.defaultConn));
            }
        }

        public async Task<IEnumerable<Flight>> GetByLocId(int originId, int destId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $@"SELECT * FROM {Flight.tableName} WHERE OriginLocID = @OriginId AND DestLocID = @DestId";
                    conn.Open();
                    var result = await conn.QueryAsync<Flight>(sQuery, new { OriginId = originId, DestId = destId });
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

        public async Task<FlightsInputsVM> GetBySearchInput(SearchFlight vm)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT * FROM {Flight.tableName} WHERE OriginLocID = @OriginId AND DestLocID = @DestId AND CAST(DepartDateTime AS DATE) = @DepartDate;";
                    //string sQuery = "SELECT * FROM Flights AS f INNER JOIN FlightSeatTypes AS fs ON f.FlightSeatTypeID = fs.ID AND f.OriginLocID = @OriginId AND f.DestLocID = @DestId AND CAST(f.DepartDateTime AS DATE) >= @DepartDate;";
                    conn.Open();
                    var flights = new FlightsInputsVM();
                    flights.GoFlights = await conn.QueryAsync<Flight>(sQuery, new { OriginId = vm.OriginID, DestId = vm.DestID, DepartDate = vm.DepartDate });

                    //if return flight option selected
                    if (vm.WaySelection == 2 && vm.ReturnDate != null)
                    {
                        flights.ReturnFlights = await conn.QueryAsync<Flight>(sQuery, new { OriginId = vm.DestID, DestId = vm.OriginID, DepartDate = vm.ReturnDate });
                    }
                    return flights;
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

        public async Task<Flight> GetByFlightId(int flightId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT * FROM {Flight.tableName} WHERE ID = @FlightId";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<Flight>(sQuery, new { FlightId = flightId });
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

        public async Task<IEnumerable<Flight>> GetAllByFlightId(IEnumerable<int> flightIds)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT * FROM {Flight.tableName} WHERE ID IN @FlightIds";
                    conn.Open();
                    var result = await conn.QueryAsync<Flight>(sQuery, new { FlightIds = flightIds });
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

        //public async Task<IEnumerable<FlightSeatType>> GetAllFlightSeatTypes()
        //{
        //    using (IDbConnection conn = Connection)
        //    {
        //        try
        //        {
        //            string sQuery = "SELECT * FROM FlightSeatTypes";
        //            conn.Open();
        //            var result = await conn.QueryAsync<FlightSeatType>(sQuery);
        //            return result;
        //        }
        //        catch (Exception)
        //        {
        //            throw;
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        public async Task<FlightSeatType> GetFlightSeatTypeById(int id)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT * FROM {FlightSeatType.tableName} WHERE ID = @Id";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<FlightSeatType>(sQuery, new { Id = id });
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

        [Authorize(Roles = RoleNames.admin)]
        public async Task<int> AddFlight(Flight flight)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"INSERT INTO {Flight.tableName} ([OriginLocID],[DestLocID],[DepartDateTime],[ArrDateTime],[Price]) VALUES (@OriginLocID, @DestLocID, @DepartDateTime, @ArrDateTime, @Price);" +
                        commonName.addReturnIntQuery;
                    conn.Open();
                    var result = await conn.QuerySingleAsync<int>(sQuery, new { OriginLocID = flight.OriginLocID,
                        DestLocID = flight.DestLocID,
                        DepartDateTime = flight.DepartDateTime,
                        ArrDateTime = flight.ArrDateTime,
                        Price = flight.Price
                        //FlightSeatTypeID = flight.FlightSeatTypeID,
                        //SeatsRemain = flight.SeatsRemain
                    });
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

        [Authorize(Roles = RoleNames.admin)]
        public async Task<int> UpdateFlight(Flight flight)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"UPDATE {Flight.tableName} SET OriginLocID = @OriginLocID, DestLocID=@DestLocID, DepartDateTime=@DepartDateTime, ArrDateTime=@ArrDateTime, Price=@Price " +
                        "WHERE ID = @Id;";
                        //commonName.addReturnIntQuery;
                    conn.Open();
                    var result = await conn.ExecuteAsync(sQuery, new
                    {
                        Id = flight.ID,
                        OriginLocID = flight.OriginLocID,
                        DestLocID = flight.DestLocID,
                        DepartDateTime = flight.DepartDateTime,
                        ArrDateTime = flight.ArrDateTime,
                        Price = flight.Price
                        //FlightSeatTypeID = flight.FlightSeatTypeID,
                        //SeatsRemain = flight.SeatsRemain
                    });
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

        public async Task<int> UpdateSeatsRemain(int count, int flightId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"UPDATE {Flight.tableName} SET SeatsRemain = ((SELECT SeatsRemain WHERE ID = @Id )+@Count) WHERE ID = @Id;";
                    conn.Open();
                    var result = await conn.ExecuteAsync(sQuery, new { Id = flightId, Count = count });

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

        #region Planes

        public async Task<IEnumerable<Plane>> GetAllPlanes()
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + Plane.tableName + ";";
                    string sQuery2 = "SELECT * FROM " + FlightSeatType.tableName + "; ";
                    conn.Open();
                    var results = await conn.QueryMultipleAsync(sQuery + sQuery2);

                    var planes = results.Read<Plane>().OrderBy(f => f.FlightSeatTypeID).ToList();
                    var flightSeatTypes = results.Read<FlightSeatType>().OrderBy(s =>s.ID).ToList();
                    int typeIdx = 0, flightSeatTypesCount = flightSeatTypes.Count();

                    for(int planeIdx = 0; planeIdx<planes.Count(); planeIdx++)
                    {
                        if(planes[planeIdx].FlightSeatTypeID == flightSeatTypes[typeIdx].ID)
                        {
                            planes[planeIdx].FlightSeatType = flightSeatTypes[typeIdx];
                        }
                        else
                        {
                            if(typeIdx + 1 < flightSeatTypesCount)
                            {
                                typeIdx++;
                                if (planes[planeIdx].FlightSeatTypeID == flightSeatTypes[typeIdx].ID)
                                {
                                    planes[planeIdx].FlightSeatType = flightSeatTypes[typeIdx];
                                }
                            }
                        }
                    }
                    return planes;
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

        public async Task<int> AddPlane(Plane plane)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"INSERT INTO {Plane.tableName} (Name, FlightSeatTypeID) VALUES (@Name, @FlightSeatTypeID)" +
                        "SELECT CAST(SCOPE_IDENTITY() as int)";
                    conn.Open();
                    var result = conn.QueryAsync<int>(sQuery, new { Name = plane.Name, FlightSeatTypeID = plane.FlightSeatTypeID }).Result.Single();
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

        public async Task<Plane> GetPlaneByFlightId(int flightId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT * FROM {Plane.tableName} WHERE ID = (SELECT PlaneID FROM {Flight.tableName} WHERE ID = @FlightId)";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<Plane>(sQuery, new { FlightId = flightId });
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

        #endregion

    }
}
