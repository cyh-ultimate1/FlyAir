using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.BookingModels
{
    public class BookingVM
    {
        public Booking Booking { get; set; }

        public byte AdultNum { get; set; }

        public byte ChildrenNum { get; set; }

        public virtual List<BookingNonMember> BookingNonMembers { get; set; }

        public virtual List<BookingMember> BookingMembers { get; set; }
    }
}
