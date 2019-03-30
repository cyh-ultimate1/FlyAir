using Dapper;
using FlyAir.Data.IRepositories;
using FlyAir.Models;
using FlyAir.Models.FlightModels;
using FlyAir.Models.IdentityEntities;
using FlyAir.Models.StaffModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyAir.Data.Repositories
{
    [Authorize(Roles = RoleNames.admin)]
    public class AdminRepo : IAdminRepo
    {
        private readonly IConfiguration _config;
        private readonly IGlobalRepo _globalRepo;

        public AdminRepo(IConfiguration config, IGlobalRepo globalRepo)
        {
            _config = config;
            _globalRepo = globalRepo;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString(commonName.defaultConn));
            }
        }

        #region Staffs

        public async Task<IEnumerable<Staff>> GetAllStaffs()
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT s.ID, s.Name, s.DateOfBirth, s.StaffTypeID, st.Type FROM " + Staff.tableName 
                    + " AS s INNER JOIN " + StaffType.tableName + " AS st ON s.StaffTypeID = st.ID; ";
                    conn.Open();
                    var result = await conn.QueryAsync<Staff>(sQuery);

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

        public async Task<IEnumerable<StaffType>> GetStaffTypesAsync()
        {
            return await _globalRepo.GetAll<StaffType>(StaffType.tableName);
        }

        public async Task<StaffType> GetStaffTypeById(byte id)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + StaffType.tableName + " WHERE ID = @Id;";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<StaffType>(sQuery, new { Id = id });
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

        public async Task<int> AddStaff(StaffVM input)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "INSERT INTO " + Staff.tableName + " (Name, DateOfBirth, StaffTypeID) VALUES(@Name, @DateOfBirth, @StaffTypeID)" +
                        "SELECT CAST(SCOPE_IDENTITY() as int)";
                    conn.Open();
                    var addedInt = conn.QueryAsync<int>(sQuery, new { Name = input.Name, DateOfBirth = input.DateOfBirth, StaffTypeID = input.StaffTypeID}).Result.Single();
                    return addedInt;
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

        public async Task<int> AddPilot(Pilot input)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "INSERT INTO " + Pilot.tableName + " (StaffID, PilotLicenceNum) VALUES(@StaffID, @PilotLicenceNum)";
                        //"SELECT CAST(SCOPE_IDENTITY() as int)";
                    conn.Open();
                    var addedInt = await conn.ExecuteAsync(sQuery, new { StaffID = input.StaffID, PilotLicenceNum = input.PilotLicenceNum });
                    return addedInt;
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

        public async Task<int> AddSteward (Steward input)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "INSERT INTO " + Steward.tableName + " (StaffID, StewardLicence) VALUES(@StaffID, @StewardLicence)";
                    //"SELECT CAST(SCOPE_IDENTITY() as int)";
                    conn.Open();
                    var addedInt = await conn.ExecuteAsync(sQuery, new { StaffID = input.StaffID, StewardLicence = input.StewardLicence });
                    return addedInt;
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

        public async Task<int> RelateStaffToUser(IdentityUserStaffs input)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "INSERT INTO " + IdentityUserStaffs.tableName + " (UserId, StaffId) VALUES(@UserId, @StaffId)";
                    //"SELECT CAST(SCOPE_IDENTITY() as int)";
                    conn.Open();
                    var addedInt = await conn.ExecuteAsync(sQuery, new { UserId = input.UserId, StaffId = input.StaffId });
                    return addedInt;
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

        public async Task<int> GetUserIdByStaffId(int staffId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT UserId FROM " + IdentityUserStaffs.tableName + " WHERE StaffId = @StaffId;";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<int>(sQuery, new { StaffId = staffId });
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

        #region Planes

        public async Task<IEnumerable<Plane>> GetAllAvailablePlanes(int flightId, byte flightSeatTypeId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "WITH f1 AS (SELECT DepartDateTime, ArrDateTime FROM Flights WHERE ID = @Id) SELECT * FROM Planes WHERE FlightSeatTypeID=@FlightSeatTypeID AND ID NOT IN(SELECT DISTINCT PlaneID FROM Flights WHERE PlaneID IS NOT NULL AND ((DepartDateTime BETWEEN(SELECT f1.DepartDateTime FROM f1) AND(SELECT f1.ArrDateTime FROM f1)) OR(ArrDateTime BETWEEN(SELECT f1.DepartDateTime FROM f1) AND(SELECT f1.ArrDateTime FROM f1)) OR(DepartDateTime <= (SELECT f1.DepartDateTime FROM f1) AND ArrDateTime >= (SELECT f1.ArrDateTime FROM f1))))";
                    conn.Open();
                    var result = await conn.QueryAsync<Plane>(sQuery, new { Id = flightId, FlightSeatTypeID = flightSeatTypeId });

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

        public async Task<FlightSeatType> GetFlightSeatTypeDetails(int flightSeatTypeId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + FlightSeatType.tableName + " WHERE ID = @FlightSeatTypeID;";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<FlightSeatType>(sQuery, new { FlightSeatTypeID = flightSeatTypeId });

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

        #region Flights

        public async Task<IEnumerable<Flight>> GetAllFlights()
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM Flights;";
                    conn.Open();
                    var result = await conn.QueryAsync<Flight>(sQuery);

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

        public int DeleteFlight(int flightId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "DELETE FROM Flights WHERE ID = @FlightId;";
                    conn.Open();
                    var result = conn.Execute(sQuery, new { FlightId = flightId });

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
                    string sQuery = "UPDATE Flights SET SeatsRemain = ((SELECT SeatsRemain WHERE ID = @Id )+@Count) WHERE ID = @Id;";
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

        #endregion

        #region FlightPlanes

        public async Task<int> UpdateFlightPlane(Flight flight)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "UPDATE Flights SET PlaneID = @PlaneID, FlightSeatTypeID = @FlightSeatTypeID, SeatsRemain = @SeatsRemain WHERE ID = @Id;";
                    conn.Open();
                    var result = await conn.ExecuteAsync(sQuery, new { Id = flight.ID, PlaneID = flight.PlaneID, FlightSeatTypeID = flight.FlightSeatTypeID, SeatsRemain = flight.SeatsRemain });

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

        #region FlightStaff

        public async Task<IEnumerable<Staff>> GetStaffsOnFlight (int flightId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM Staffs WHERE ID IN (SELECT StaffID FROM FlightsStaffs WHERE FlightID = @FlightID);";
                    conn.Open();
                    var result = await conn.QueryAsync<Staff>(sQuery, new { FlightID = flightId });

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

        public async Task<IEnumerable<Staff>> GetAvailableStaffs(int flightId, int staffTypeId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "WITH f1 AS (SELECT DepartDateTime, ArrDateTime FROM Flights WHERE ID = @FlightID), f2 AS( SELECT ID FROM Flights WHERE (DepartDateTime BETWEEN (SELECT f1.DepartDateTime FROM f1) AND(SELECT f1.ArrDateTime FROM f1)) OR(ArrDateTime BETWEEN(SELECT f1.DepartDateTime FROM f1) AND(SELECT f1.ArrDateTime FROM f1)) OR(DepartDateTime <= (SELECT f1.DepartDateTime FROM f1) AND ArrDateTime >= (SELECT f1.ArrDateTime FROM f1))) SELECT* FROM Staffs WHERE StaffTypeID = @StaffTypeID AND ID NOT IN(SELECT DISTINCT StaffID FROM FlightsStaffs WHERE StaffID IS NOT NULL AND FlightID IN (SELECT f2.ID FROM f2))";
                    conn.Open();
                    var result = await conn.QueryAsync<Staff>(sQuery, new { FlightID = flightId, StaffTypeID = staffTypeId });

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

        public async Task<int> AddFlightStaffs(int flightId, IEnumerable<int> selectedStaffsId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    StringBuilder sQuery = new StringBuilder();
                    var list1 = new List<FlightStaffQuery>();

                    sQuery.Append("INSERT INTO FlightsStaffs (FlightID, StaffID) VALUES ( @FlightId, @SelectedStaffsId )");
                        for(int idx=0; idx<selectedStaffsId.Count(); idx++)
                    {
                        list1.Add(new FlightStaffQuery { FlightId = flightId, SelectedStaffsId = selectedStaffsId.ElementAt(idx) });
                    }
                    conn.Open();
                    var result = await conn.ExecuteAsync(sQuery.ToString(), list1);

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

        public async Task<int> DeleteFlightStaffs(int flightId, IEnumerable<int> selectedStaffsId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    StringBuilder sQuery = new StringBuilder();
                    var list1 = new List<FlightStaffQuery>();

                    sQuery.Append("DELETE FROM FlightsStaffs WHERE FlightID = @FlightID AND StaffID = @SelectedStaffsId;");
                    for (int idx = 0; idx < selectedStaffsId.Count(); idx++)
                    {
                        list1.Add(new FlightStaffQuery { FlightId = flightId, SelectedStaffsId = selectedStaffsId.ElementAt(idx) });
                    }
                    conn.Open();
                    var result = await conn.ExecuteAsync(sQuery.ToString(), list1);

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


        #region Roles

        public async Task<IEnumerable<Role>> GetAllRoles()
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + commonName.identityRoleTable + "; ";
                    conn.Open();
                    var result = await conn.QueryAsync<Role>(sQuery);

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

        public async Task<UserAndRole> GetUserRoleByUserid(int userId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + UserAndRole.tableName + " WHERE UserId = @UserId; ";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<UserAndRole>(sQuery, new { UserId = userId });

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

        public async Task<int> UpdateUserAndRole(UserAndRole input)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "UPDATE " + UserAndRole.tableName + " SET RoleId = @RoleId WHERE UserId = @UserId; ";
                    conn.Open();
                    var result = await conn.ExecuteAsync(sQuery, new { UserId = input.UserId, RoleId = input.RoleId });

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
