using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.BookingModels
{
    public class SelectSeatViewVM
    {
        public SelectSeatViewVM()
        {
            SeatsTakenGoFlight = new List<string>();
            SeatsTakenReturnFlight = new List<string>();
        }

        public Booking Booking { get; set; }

        public List<BookingNonMember> BookingNonMembersList { get; set; }

        public List<string> SeatsTakenGoFlight { get; set; }
        public List<string> SeatsTakenReturnFlight { get; set; }
    }
}
