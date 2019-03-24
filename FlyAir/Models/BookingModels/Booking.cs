using FlyAir.Models.FlightModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.BookingModels
{
    public class Booking
    {
        public int ID { get; set; }

        public DateTime DateTimeCreated { get; set; }

        public int GoFlightId { get; set; }

        public int ReturnFlightId { get; set; }

        public int MemberId { get; set; }

        public bool HasCheckedIn { get; set; }

        public virtual Flight GoFlight { get; set; }

        public virtual Flight ReturnFlight { get; set; }

        //table name
        public const string tableName = "Bookings";
    }
}
