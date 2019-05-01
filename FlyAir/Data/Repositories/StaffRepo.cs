using Dapper;
using FlyAir.Data.IRepositories;
using FlyAir.Models;
using FlyAir.Models.FlightModels;
using FlyAir.Models.IdentityEntities;
using FlyAir.Models.StaffModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.Repositories
{
    public class StaffRepo : IStaffRepo
    {
        private readonly IConfiguration _config;
        private readonly IGlobalRepo _globalRepo;

        public StaffRepo(IConfiguration config, IGlobalRepo globalRepo)
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

        public async Task<int> GetStaffIdByUserId(int userid)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT ID FROM {Staff.tableName} WHERE {nameof(Staff.UserID)} = @UserId;";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<int>(sQuery, new { UserId = userid });
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

        public async Task<StaffVM> GetStaffDetails(int staffid)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT s.ID, s.Name, s.DateOfBirth, s.StaffTypeID, st.Type FROM " + Staff.tableName
                    + " AS s INNER JOIN " + StaffType.tableName + " AS st ON (s.ID = @StafFId AND s.StaffTypeID = st.ID); ";
                    conn.Open();
                    var result = await conn.QuerySingleAsync<StaffVM>(sQuery, new { StaffId = staffid } );

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

        public async Task<IEnumerable<Flight>> GetStaffFlights(int staffId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = "SELECT * FROM " + Flight.tableName + " WHERE ID IN (SELECT FlightID FROM " + FlightsStaffs.tableName + " WHERE StaffID = @StaffId);";
                    conn.Open();
                    var result = await conn.QueryAsync<Flight>(sQuery, new { StaffId = staffId });

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
    }
}
