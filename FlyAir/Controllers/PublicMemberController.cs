using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyAir.Data.IRepositories;
using FlyAir.Models.IdentityEntities;
using FlyAir.Models.PublicMemberModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FlyAir.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Authorize]
    public class PublicMemberController : Controller
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly ICountryRepo _countryRepo;
        private readonly IFlightRepo _flightRepo;
        private readonly IBookingRepo _bookingRepo;
        private readonly IGlobalRepo _globalRepo;

        public PublicMemberController(UserManager<CustomUser> userManager, 
            ICountryRepo countryRepo, 
            IFlightRepo flightRepo, 
            IBookingRepo bookingRepo, 
            IGlobalRepo globalRepo)
        {
            _userManager = userManager;
            _countryRepo = countryRepo;
            _flightRepo = flightRepo;
            _bookingRepo = bookingRepo;
            _globalRepo = globalRepo;
        }

        public async Task<IActionResult> MemberAccountDetails()
        {
            PublicMemberAccDetVM vm = new PublicMemberAccDetVM()
            {
                User = await _globalRepo.GetCurrentUserAsync()
            };

            var bookings = (await _bookingRepo.GetMemberBookings(vm.User.Id.ToString()));
            var bookingsFlightList = bookings.Select(b => b.GoFlightId).Concat(bookings.Select(b => b.ReturnFlightId));
            vm.LatestFlight = (await _flightRepo.GetAllByFlightId(bookingsFlightList)).Where(t=>t.DepartDateTime >= DateTime.Now).OrderBy(f=>f.DepartDateTime).FirstOrDefault();
            if(vm.LatestFlight != null)
            {
                vm.LatestFlight.OriginLoc1 = await _countryRepo.GetLocById(vm.LatestFlight.OriginLocID);
                vm.LatestFlight.DestLoc1 = await _countryRepo.GetLocById(vm.LatestFlight.DestLocID);
            }

            return View(vm);
        }


    }
}