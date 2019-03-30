using FlyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.IRepositories
{
    public interface IdummyRepo
    {
        Task<IEnumerable<dummyModel>> GetAll();
        Task<IEnumerable<dummyModel>> GetAllSqlDep();
        Task<IEnumerable<dummyModel>> GetSqlTblDep();
    }
}
