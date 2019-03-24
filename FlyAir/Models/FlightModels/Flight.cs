using FlyAir.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class Flight
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Origin")]
        public int OriginLocID { get; set; }

        [Required]
        [Display(Name = "Destination")]
        public int DestLocID { get; set; }

        public DateTime DepartDateTime { get; set; }

        public DateTime ArrDateTime { get; set; }

        public decimal Price { get; set; }

        public byte FlightSeatTypeID { get; set; }

        public Int16 SeatsRemain { get; set; }

        public Int16 PlaneID { get; set; }

        public virtual LocationVM OriginLoc { get; set; }

        public virtual LocationVM DestLoc { get; set; }

        public virtual Location OriginLoc1 { get; set; }
        public virtual Location DestLoc1 { get; set; }

        public virtual FlightSeatType FlightSeatType { get; set; }

        //table name
        public const string tableName = "Flights";
    }
}
