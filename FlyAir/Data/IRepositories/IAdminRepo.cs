using FlyAir.Models.FlightModels;
using FlyAir.Models.IdentityEntities;
using FlyAir.Models.StaffModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.IRepositories
{
    public interface IAdminRepo
    {
        Task<IEnumerable<Staff>> GetAllStaffs();
        Task<IEnumerable<StaffType>> GetStaffTypesAsync();
        Task<int> AddStaff(StaffVM input);
        Task<StaffType> GetStaffTypeById(byte id);
        Task<int> AddPilot(Pilot input);
        Task<int> AddSteward(Steward input);
        Task<IEnumerable<Plane>> GetAllAvailablePlanes(int flightId, byte flightSeatTypeId);
        Task<int> UpdateFlightPlane(Flight flight);
        Task<IEnumerable<Staff>> GetStaffsOnFlight(int flightId);
        Task<IEnumerable<Staff>> GetAvailableStaffs(int flightId, int staffTypeId);
        Task<int> AddFlightStaffs(int flightId, IEnumerable<int> selectedStaffsId);
        int DeleteFlight(int flightId);
        Task<int> DeleteFlightStaffs(int flightId, IEnumerable<int> selectedStaffsId);
        Task<IEnumerable<Role>> GetAllRoles();
        Task<UserAndRole> GetUserRoleByUserid(int userId);
        Task<int> GetUserIdByStaffId(int staffId);
        Task<int> UpdateUserAndRole(UserAndRole input);
        Task<FlightSeatType> GetFlightSeatTypeDetails(int flightSeatTypeId);
        Task<int> UpdateSeatsRemain(int count, int flightId);
    }
}
