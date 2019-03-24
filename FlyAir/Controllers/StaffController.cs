using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyAir.Data.IRepositories;
using FlyAir.Models.FlightModels;
using FlyAir.Models.IdentityEntities;
using FlyAir.Models.StaffModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FlyAir.Controllers
{
    public class StaffController : Controller
    {
        private readonly UserManager<CustomUser> _userManager;
        private readonly ICountryRepo _countryRepo;
        private readonly IFlightRepo _flightRepo;
        private readonly IBookingRepo _bookingRepo;
        private readonly IAdminRepo _adminRepo;
        private readonly IGlobalRepo _globalRepo;
        private readonly IStaffRepo _staffRepo;

        public StaffController(UserManager<CustomUser> userManager, ICountryRepo countryRepo, IFlightRepo flightRepo, IBookingRepo bookingRepo, IAdminRepo adminRepo, IGlobalRepo globalRepo, IStaffRepo staffRepo)
        {
            _userManager = userManager;
            _countryRepo = countryRepo;
            _flightRepo = flightRepo;
            _bookingRepo = bookingRepo;
            _adminRepo = adminRepo;
            _globalRepo = globalRepo;
            _staffRepo = staffRepo;
        }

        public async Task<IActionResult> Index()
        {
            //get current user staff id
            var userid = _globalRepo.GetCurrentUserId();
            var staffId = await _staffRepo.GetStaffIdByUserId(userid);

            //get current user staff details
            var staff = await _staffRepo.GetStaffDetails(staffId);

            var flights = (await _staffRepo.GetStaffFlights(staffId)).ToList();
            var flights2 = new List<Flight>();

            //below is to get only flights which are at least today or later
            foreach(var f in flights)
            {
                if(f.DepartDateTime.Date >= DateTime.Today)
                {
                    f.OriginLoc1 = await _countryRepo.GetLocById(f.OriginLocID);
                    f.DestLoc1 = await _countryRepo.GetLocById(f.DestLocID);
                    flights2.Add(f);
                }
                
            }

            //save the selected flights to staff object
            staff.Flights = flights2;

            return View(staff);
        }


    }
}