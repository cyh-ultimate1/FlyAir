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

        [Display(Name = "Depart Date Time")]
        public DateTime DepartDateTime { get; set; }

        [Display(Name = "Arrival Date Time")]
        public DateTime ArrDateTime { get; set; }

        public decimal Price { get; set; }

        [Display(Name = "Flight Seat Type")]
        public byte FlightSeatTypeID { get; set; }

        [Display(Name = "Seats Remain")]
        public Int16 SeatsRemain { get; set; }

        [Display(Name = "Plane ID")]
        public Int16 PlaneID { get; set; }

        public virtual LocationVM OriginLoc { get; set; }

        public virtual LocationVM DestLoc { get; set; }

        [Display(Name = "Origin")]
        public virtual Location OriginLoc1 { get; set; }

        [Display(Name = "Destination")]
        public virtual Location DestLoc1 { get; set; }

        public virtual FlightSeatType FlightSeatType { get; set; }

        //table name
        public const string tableName = "Flights";
    }
}
