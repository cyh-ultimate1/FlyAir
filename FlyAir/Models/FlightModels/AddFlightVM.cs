using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.FlightModels
{
    public class AddFlightVM
    {
        public Flight Flight { get; set; }

        public IEnumerable<SelectListItem> FlightSeatTypes { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public virtual IEnumerable<SelectListItem> CitySelectList1 { get; set; }
        public virtual IEnumerable<SelectListItem> CitySelectList2 { get; set; }

        [Required]
        public int OriginCountryID { get; set; }

        [Required]
        public int DestCountryID { get; set; }

        [Required]
        [Display(Name = "Depart Date" )]
        [DataType(DataType.Date)]
        public DateTime? DepartDate { get; set; }

        [Required]
        [Display(Name = "Arrival Date")]
        [DataType(DataType.Date)]
        public DateTime? ArrDate { get; set; }

        [Required]
        [Display(Name = "Depart Time")]
        [DataType(DataType.Time)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm}")]
        public DateTime? DepartTime { get; set; }

        [Required]
        [Display(Name = "Arrival Time")]
        [DataType(DataType.Time)]
        public DateTime? ArrTime { get; set; }

    }
}
