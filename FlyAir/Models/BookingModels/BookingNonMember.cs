using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.BookingModels
{
    public class BookingNonMember
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public byte Age { get; set; }

        public int BookingID { get; set; }

        public bool IsMainPayer { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Passport ID")]
        public string PassportNum { get; set; }

        public string SeatNumLetterGoFlight { get; set; }

        public byte? SeatNumDigitGoFlight { get; set; }

        public string SeatNumLetterReturnFlight { get; set; }

        public byte? SeatNumDigitReturnFlight { get; set; }

        //table name
        public const string tableName = "BookingNonMember";
    }
}
