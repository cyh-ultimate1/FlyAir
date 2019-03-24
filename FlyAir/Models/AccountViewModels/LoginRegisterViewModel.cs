using Identity.Dapper.Samples.Web.Models.AccountViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Dapper.Samples.Web.Models.AccountViewModels
{
    public class LoginRegisterViewModel
    {
        public LoginViewModel LoginViewModel { get; set; }

        public RegisterViewModel RegisterViewModel { get; set; }

        public bool IsLogin { get; set; } = true;

        public bool IsStaff { get; set; } = false;
    }
}
