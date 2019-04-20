using FlyAir.Models.BookingModels;
using FlyAir.Models.FlightModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Data.IRepositories
{
    public interface IBookingRepo
    {
        Task<int> AddBooking(Booking booking, string memberId = null);
        Task<int> AddBookingGuests(BookingNonMember booking, int bookingId);
        Task<IEnumerable<Booking>> GetMemberBookings(string userId);
        Task<Booking> GetBookingById(int bookingId);
        Task<BookingVM> GetBookingWGuestsById(int bookingId);
        Task<IEnumerable<string>> GetSeatsTakenByFlightId(int flightId, bool isGoOrReturn);
        Task<int> UpdateGuestsSeats(BookingNonMember input);
        Task<int> UpdateHasCheckedIn(int bookingId);
        Task<int> subscribeBookingAdd(int locId1, int locId2, string groupName);
        Task<IEnumerable<FlightDestCount>> GetAllDestinationCount();
    }
}
