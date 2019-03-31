using FlyAir.Models.FlightModels;
using FlyAir.Models.SearchModels;
using FlyAir.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.IRepositories
{
    public interface IFlightRepo
    {
        Task<IEnumerable<Flight>> GetByLocId(int originId, int destId);
        Task<FlightsInputsVM> GetBySearchInput(SearchFlight vm);
        Task<Flight> GetByFlightId(int flightId);
        Task<IEnumerable<Flight>> GetAllByFlightId(IEnumerable<int> flightIds);
        //Task<IEnumerable<FlightSeatType>> GetAllFlightSeatTypes();
        Task<int> AddFlight(Flight flight);
        Task<FlightSeatType> GetFlightSeatTypeById(int id);
        Task<int> AddPlane(Plane plane);
        Task<IEnumerable<Plane>> GetAllPlanes();
        Task<Plane> GetPlaneByFlightId(int flightId);
        Task<int> UpdateFlight(Flight flight);
        Task<int> UpdateSeatsRemain(int count, int flightId);
    }
}
