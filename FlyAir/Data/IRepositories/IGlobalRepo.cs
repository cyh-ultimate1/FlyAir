using FlyAir.Models.IdentityEntities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.IRepositories
{
    public interface IGlobalRepo
    {
        Task<IEnumerable<T>> GetAll<T>(string tableName);
        int GetCurrentUserId();
        Task<CustomUser> GetCurrentUserAsync();
        void SaveObjToSessionJSON<T>(string varName, object obj);
        T GetObjFromSessionJSON<T>(string varName);
        T GetJObjVar<T>(JObject obj, string varName);
        void SaveExceptionToLogFile(Exception ex);
    }
}
