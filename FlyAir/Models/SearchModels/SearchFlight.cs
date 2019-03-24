using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.SearchModels
{
    public class SearchFlight
    {
        [Required]
        public int OriginID { get; set; }

        [Required]
        public int DestID { get; set; }

        [Required]
        [Display(Name = "Origin Name")]
        public string OriginName { get; set; }

        [Required]
        [Display(Name = "Destination Name")]
        public string DestName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DepartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }

        public byte AdultNum { get; set; }

        public byte ChildrenNum { get; set; }

        public byte WaySelection { get; set; }
    }
}
