using Dapper;
using FlyAir.Data.IRepositories;
using FlyAir.Models;
using FlyAir.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.Repositories
{
    public class CountryRepo : ICountryRepo
    {
        private readonly IConfiguration _config;

        public CountryRepo(IConfiguration config)
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

        //public async Task<IEnumerable<Country>> GetAll()
        //{
        //    using (IDbConnection conn = Connection)
        //    {
        //        try
        //        {
        //            string sQuery = "SELECT * FROM Countries";
        //            conn.Open();
        //            var result = await conn.QueryAsync<Country>(sQuery);
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

        public async Task<IEnumerable<Country>> GetByInput(string input)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT * FROM {Country.tableName} WHERE CountryName LIKE @Input ";
                    conn.Open();
                    var result = await conn.QueryAsync<Country>(sQuery, new { Input = "%" + input + "%"});
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

        public async Task<IEnumerable<LocationVM>> GetLocByInput(string input)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT loc.ID, loc.City, c.CountryName FROM (SELECT * FROM {Location.tableName} WHERE City LIKE @Input) AS loc INNER JOIN {Country.tableName} AS c ON loc.CountryID = c.ID ";
                    conn.Open();
                    var result = await conn.QueryAsync<LocationVM>(sQuery, new { Input = "%" + input + "%" });
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

        public async Task<IEnumerable<LocationVM>> GetAllLocById(IEnumerable<int> locIds)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT loc.ID, loc.City, c.CountryName FROM (SELECT * FROM {Location.tableName} WHERE ID IN @LocIds) AS loc INNER JOIN {Country.tableName} AS c ON loc.CountryID = c.ID";
                    conn.Open();
                    var result = await conn.QueryAsync<LocationVM>(sQuery, new { LocIds = locIds });
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

        public async Task<IEnumerable<Location>> GetAllLocById2(IEnumerable<int> locIds)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT loc.ID, loc.City, c.CountryName FROM (SELECT * FROM {Location.tableName} WHERE ID IN @LocIds) AS loc INNER JOIN {Country.tableName} AS c ON loc.CountryID = c.ID";
                    conn.Open();
                    var result = await conn.QueryAsync<Location>(sQuery, new { LocIds = locIds });
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

        public async Task<IEnumerable<Location>> GetCitiesByCountryId(int countryId)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    string sQuery = $"SELECT * FROM {Location.tableName} WHERE CountryID = @CountryId";
                    conn.Open();
                    var result = await conn.QueryAsync<Location>(sQuery, new { CountryId = countryId });
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
                    string sQuery = $"SELECT loc.ID, loc.City, loc.CountryID, c.CountryName FROM {Location.tableName} AS loc INNER JOIN {Country.tableName} AS c ON loc.ID = @Id AND c.ID = loc.CountryID";
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
    }
}
