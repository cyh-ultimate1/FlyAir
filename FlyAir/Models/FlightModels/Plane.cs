using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class Plane
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public byte FlightSeatTypeID { get; set; }

        public virtual FlightSeatType FlightSeatType { get; set; }

        //table name
        public const string tableName = "Planes";
    }
}
