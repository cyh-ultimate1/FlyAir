using Dapper;
using FlyAir.Data.IRepositories;
using FlyAir.Models;
using FlyAir.Models.FlightModels;
using FlyAir.Models.IdentityEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using mySession.Data.Extensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.Repositories
{
    public class GlobalRepo : IGlobalRepo
    {
        private readonly IConfiguration _config;
        private readonly UserManager<CustomUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GlobalRepo(IConfiguration config, UserManager<CustomUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString(commonName.defaultConn));
            }
        }

        public async Task<IEnumerable<T>> GetAll<T>(string tableName)
        {
            using (IDbConnection conn = Connection)
            {
                try
                {
                    //string sQuery = "SELECT * FROM " + typeof(T).Name + "s;";
                    string sQuery = "SELECT * FROM " + tableName;
                    conn.Open();
                    var result = await conn.QueryAsync<T>(sQuery);
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

        public int GetCurrentUserId()
        {
            return Convert.ToInt16(_userManager.GetUserId(_httpContextAccessor.HttpContext.User));
        }

        public async Task<CustomUser> GetCurrentUserAsync()
        {
            return await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        }

        //varname is the session variable name
        public void SaveObjToSessionJSON<T>(string varName, object obj)
        {
            SessionHelper.SetObjectAsJson<T>(_httpContextAccessor.HttpContext.Session, varName, obj);
        }

        //varname is the session variable name
        public T GetObjFromSessionJSON<T>(string varName)
        {
            return SessionHelper.GetObjectFromJson<T>(_httpContextAccessor.HttpContext.Session, varName);
        }

        //varname is the jobject property variable name
        public T GetJObjVar<T>(JObject obj, string varName)
        {
            return (obj[varName].Value<T>());
        }
    }
}
