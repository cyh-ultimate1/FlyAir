using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.IdentityEntities
{
    public class IdentityUserStaffs
    {
        public int UserId { get; set; }

        public int StaffId { get; set; }

        //table name
        public const string tableName = "IdentityUserStaffs";
    }
}
