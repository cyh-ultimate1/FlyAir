using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class FlightSeatType
    {
        public byte ID { get; set; }

        public byte NumSeatsLeft { get; set; }

        public byte NumSeatsRight { get; set; }

        public byte NumSeatsCenter { get; set; }

        public byte NumRows { get; set; }

        //table name
        public const string tableName = "FlightSeatTypes";
    }
}
