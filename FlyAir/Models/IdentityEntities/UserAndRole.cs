using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyAir.Models.IdentityEntities
{
    public class UserAndRole
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public virtual List<SelectListItem> RolesList { get; set; }

        //table name
        public const string tableName = "IdentityUserRole";
    }
}
