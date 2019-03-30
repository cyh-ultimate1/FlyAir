using FlyAir.Models.FlightModels;
using FlyAir.Models.StaffModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.IRepositories
{
    public interface IStaffRepo
    {
        Task<int> GetStaffIdByUserId(int userid);
        Task<StaffVM> GetStaffDetails(int staffid);
        Task<IEnumerable<Flight>> GetStaffFlights(int staffId);
    }
}
