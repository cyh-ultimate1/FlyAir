using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyAir.Data.IRepositories;
using FlyAir.Models;
using FlyAir.Models.BookingModels;
using FlyAir.Models.FlightModels;
using FlyAir.Models.IdentityEntities;
using FlyAir.Models.StaffModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using mySession.Data.Extensions;
using Newtonsoft.Json.Linq;

namespace FlyAir.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Authorize(Roles = RoleNames.admin)]
    public class AdminController : Controller
    {
        private readonly ICountryRepo _countryRepo;
        private readonly IFlightRepo _flightRepo;
        private readonly IBookingRepo _bookingRepo;
        private readonly IAdminRepo _adminRepo;
        private readonly IGlobalRepo _globalRepo;

        public AdminController(ICountryRepo countryRepo, IFlightRepo flightRepo, IBookingRepo bookingRepo, IAdminRepo adminRepo, IGlobalRepo globalRepo)
        {
            _countryRepo = countryRepo;
            _flightRepo = flightRepo;
            _bookingRepo = bookingRepo;
            _adminRepo = adminRepo;
            _globalRepo = globalRepo;
        }

        public async Task<IActionResult> Dashboard()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<JsonResult>> GetTopDestination()
        {
            var topN = 5;
            //get all destination count and sort and take top N 
            var flightDestCount = (await _bookingRepo.GetAllDestinationCount());
            flightDestCount = flightDestCount.OrderByDescending(a => a.FreqCount).Take(topN).ToList();
            if(flightDestCount != null && flightDestCount.Count() >= topN)
            {
                return Json(flightDestCount);
            }

            //if reach here, means destination is null or not enough number of destination
            return NotFound("null or not enough destination");
        }

        #region HandleFlights

        public async Task<IActionResult> ViewAllFlights()
        {
            //get all flights and get list of location
            var flights = await _globalRepo.GetAll<Flight>(Flight.tableName);
            var locations = (await _countryRepo.GetAllLocById2(flights.Select(s => s.OriginLocID).Concat(flights.Select(s => s.DestLocID)).Distinct())).OrderBy(o=>o.ID);

            //iterate through origin flights ordered by loc id and assign location details
            int i = 0;
            foreach (var f in flights.OrderBy(o=>o.OriginLocID))
            {
                while(f.OriginLocID != locations.ElementAt(i).ID)   //iterate to the next location details if not matched
                {
                    i++;
                }
                f.OriginLoc1 = locations.ElementAt(i);
            }

            //iterate through return flights ordered by loc id and assign location details
            i = 0;
            foreach (var f in flights.OrderBy(o => o.DestLocID))
            {
                while (f.DestLocID != locations.ElementAt(i).ID) //iterate to the next location details if not matched
                {
                    i++;
                }
                f.DestLoc1 = locations.ElementAt(i);
            }
            return View(flights);
        }

        public async Task<IActionResult> ViewFlightStaffs(int id)
        {

            return View();
        }

        //redirect to AddFlight view
        public async Task<IActionResult> AddFlight()
        {
            var countries = await _globalRepo.GetAll<Country>(Country.tableName);
            var flightSeatTypes = await _globalRepo.GetAll<FlightSeatType>(FlightSeatType.tableName);
            var flightVM = new AddFlightVM
            {
                Flight = new Flight {
                    DestLoc = new ViewModels.LocationVM()
                },
                FlightSeatTypes = flightSeatTypes.Select(s => new SelectListItem { Value = s.ID.ToString(), Text = "Rows: " + s.NumRows + ", Left: " + s.NumSeatsLeft + ", Center: " + s.NumSeatsCenter + ", Right: " + s.NumSeatsRight }),
                Countries = countries.Select(s => new SelectListItem { Value = s.ID.ToString(), Text = s.CountryName })
            };
            return View(flightVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddFlight(AddFlightVM vm)
        {
            var depDate = vm.DepartDate.Value; var depTime = vm.DepartTime.Value;
            var arrDate = vm.ArrDate.Value; var arrTime = vm.ArrTime.Value;
            vm.Flight.DepartDateTime = new DateTime(depDate.Year, depDate.Month, depDate.Day, depTime.Hour, depTime.Minute, depTime.Second);
            vm.Flight.ArrDateTime = new DateTime(arrDate.Year, arrDate.Month, arrDate.Day, arrTime.Hour, arrTime.Minute, arrTime.Second);
            //var flightSeat = await _flightRepo.GetFlightSeatTypeById(vm.Flight.FlightSeatTypeID);
            //vm.Flight.SeatsRemain = Convert.ToInt16( flightSeat.NumRows * (flightSeat.NumSeatsLeft + flightSeat.NumSeatsCenter + flightSeat.NumSeatsRight));
            var returnId = await _flightRepo.AddFlight(vm.Flight);
            return RedirectToAction(nameof(AddFlightPlane), "Admin", new { flightId = returnId } );
        }

        public async Task<IActionResult> EditFlight(int flightId)
        {
            var countries = await _globalRepo.GetAll<Country>(Country.tableName);
            var flightVM = new AddFlightVM
            {
                Flight = await _flightRepo.GetByFlightId(flightId),
                Countries = countries.Select(s => new SelectListItem { Value = s.ID.ToString(), Text = s.CountryName, Selected = true })
            };
            flightVM.OriginCountryID = _countryRepo.GetLocById(flightVM.Flight.OriginLocID).Result.CountryID;
            flightVM.CitySelectList1 = (await _countryRepo.GetCitiesByCountryId(flightVM.OriginCountryID)).Select(s => new SelectListItem { Value = s.ID.ToString(), Text = s.City, Selected = true });

            flightVM.DestCountryID = _countryRepo.GetLocById(flightVM.Flight.DestLocID).Result.CountryID;
            flightVM.CitySelectList2 = (await _countryRepo.GetCitiesByCountryId(flightVM.DestCountryID)).Select(s => new SelectListItem { Value = s.ID.ToString(), Text = s.City, Selected = true });

            flightVM.DepartDate = flightVM.Flight.DepartDateTime.Date;
            flightVM.DepartTime = flightVM.Flight.DepartDateTime;
            flightVM.ArrDate = flightVM.Flight.ArrDateTime.Date;
            flightVM.ArrTime = flightVM.Flight.ArrDateTime;
            return View(flightVM);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFlight(AddFlightVM vm)
        {
            var depDate = vm.DepartDate.Value; var depTime = vm.DepartTime.Value;
            var arrDate = vm.ArrDate.Value; var arrTime = vm.ArrTime.Value;
            vm.Flight.DepartDateTime = new DateTime(depDate.Year, depDate.Month, depDate.Day, depTime.Hour, depTime.Minute, depTime.Second);
            vm.Flight.ArrDateTime = new DateTime(arrDate.Year, arrDate.Month, arrDate.Day, arrTime.Hour, arrTime.Minute, arrTime.Second);

            var returnId = await _flightRepo.UpdateFlight(vm.Flight);

            return RedirectToAction(nameof(ViewAllFlights));
        }

        public IActionResult DeleteFlight(int flightId)
        {
            var result = _adminRepo.DeleteFlight(flightId);

            return RedirectToAction(nameof(ViewAllFlights));
        }

        public async Task<IActionResult> AddFlightPlane(int flightId)
        {
            var vm = new AddFlightPlaneVM
            {
                Flight = await _flightRepo.GetByFlightId(flightId),
                //Plane = new Plane (),
                FlightSeatTypes = (await _globalRepo.GetAll<FlightSeatType>(FlightSeatType.tableName)).Select(s => new SelectListItem { Value = s.ID.ToString(), Text = "Rows: " + s.NumRows + ", Left: " + s.NumSeatsLeft + ", Center: " + s.NumSeatsCenter + ", Right: " + s.NumSeatsRight })
            };
            if (vm.Flight.PlaneID != null && vm.Flight.PlaneID > 0)
            {
                vm.Plane = await _flightRepo.GetPlaneByFlightId(flightId);
            }
            else
            {
                vm.Plane = new Plane();
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddFlightPlane(AddFlightPlaneVM vm)
        {
            //get flight seat details to calc default seats remain
            var flightSeatTypeDetails = await _adminRepo.GetFlightSeatTypeDetails(vm.Flight.FlightSeatTypeID);
            vm.Flight.SeatsRemain = (Int16)((flightSeatTypeDetails.NumSeatsCenter + flightSeatTypeDetails.NumSeatsLeft + flightSeatTypeDetails.NumSeatsRight) * flightSeatTypeDetails.NumRows);

            //update Flight
            var result = await _adminRepo.UpdateFlightPlane(vm.Flight);

            return RedirectToAction(nameof(ViewAllFlights), "Admin" , null);
        }

        public async Task<IActionResult> AddFlightStaffs(int flightId)
        {
            var staffs = await _adminRepo.GetStaffsOnFlight(flightId);
            SessionHelper.SetObjectAsJson<IEnumerable<int>>(HttpContext.Session, "staffsOnFlight", staffs.Select(s => s.ID));
            var vm = new AddFlightStaffsVM
            {
                Flight = await _flightRepo.GetByFlightId(flightId),
                StaffsOnFlight = await _adminRepo.GetStaffsOnFlight(flightId),
                PilotsAvailable = (await _adminRepo.GetAvailableStaffs(flightId, 1)).Select(s => new SelectListItem { Value = s.ID.ToString(), Text = s.Name }),
                StewardsAvailable = (await _adminRepo.GetAvailableStaffs(flightId, 2)).Select(s => new SelectListItem { Value = s.ID.ToString(), Text = s.Name })
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddFlightStaffs(AddFlightStaffsVM vm)
        {
            var staffsOnFlight = SessionHelper.GetObjectFromJson<IEnumerable<int>>(HttpContext.Session, "staffsOnFlight");
            var staffSelectedIdList = new List<int>();
            var staffSelectedIdList2 = new List<int>();

            if(vm.PilotsSelectedId != null)
            {
                staffSelectedIdList.AddRange(vm.PilotsSelectedId.Except(staffsOnFlight));
                staffSelectedIdList2.AddRange(vm.PilotsSelectedId);
            }
            if(vm.StewardsSelectedId != null)
            {
                staffSelectedIdList.AddRange(vm.StewardsSelectedId.Except(staffsOnFlight));
                staffSelectedIdList2.AddRange(vm.StewardsSelectedId);
            }

            var result = await _adminRepo.AddFlightStaffs(vm.Flight.ID, staffSelectedIdList);
            var staffToBeDeleted = staffsOnFlight.Except(staffSelectedIdList2);

            if(staffToBeDeleted != null && staffToBeDeleted.Count() > 0)
            {
                var result2 = await _adminRepo.DeleteFlightStaffs(vm.Flight.ID, staffToBeDeleted);
            }

            HttpContext.Session.Remove("staffsOnFlight");

            return RedirectToAction(nameof(ViewAllFlights));
        }

        public async Task<IActionResult> dummyOnly()
        {


            var results = _adminRepo.AddFlightStaffs(26, new int[] { 1,2,3 });
            return View();
        }

        #endregion

        #region HandleLocation

        [HttpGet]
        public async Task<JsonResult> GetCityByCountryId(int reqData)
        {
            var result = await _countryRepo.GetCitiesByCountryId(reqData);
            if(result == null)
            {
                return null;
            }
            return Json(result);
        }

        #endregion

        #region HandlePlanes

        public async Task<IActionResult> ViewAllPlanes()
        {
            var result = await _flightRepo.GetAllPlanes();
            return View(result);
        }

        public async Task<IActionResult> AddPlane()
        {
            AddPlaneVM vm = new AddPlaneVM
            {
                FlightSeatTypes = (await _globalRepo.GetAll<FlightSeatType>(FlightSeatType.tableName)).Select(s => new SelectListItem { Value = s.ID.ToString(), Text = "Rows: " + s.NumRows + ", Left: " + s.NumSeatsLeft + ", Center: " + s.NumSeatsCenter + ", Right: " + s.NumSeatsRight }).ToList()
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlane(AddPlaneVM vm)
        {
            var result = await _flightRepo.AddPlane(vm.Plane);
            return RedirectToAction(nameof(ViewAllPlanes));
        }

        [HttpGet]
        public async Task<JsonResult> GetAllAvailablePlanes(int flightId, byte flightSeatTypeId)
        {
            try
            {
                var result = await _adminRepo.GetAllAvailablePlanes(flightId, flightSeatTypeId);

                return Json(result);
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }

        #endregion


        #region HandleStaffs

        public async Task<IActionResult> ViewAllStaffs()
        {
            var results = await _adminRepo.GetAllStaffs();
            return View(results);
        }

        public async Task<IActionResult> AddNewStaffAccount()
        {
            return View();
        }

        //[Route("Admin/ToAddStaff")]
        public async Task<IActionResult> AddStaff(int tempUserId)
        {
            StaffVM vm = new StaffVM
            {
                StaffTypesList = (await _adminRepo.GetStaffTypesAsync()).Select(s => new SelectListItem { Value = s.ID.ToString(), Text = s.Type }).ToList(),
                tempUserid = tempUserId,
                DateOfBirth = DateTime.Today
            };

            //HttpContext.Session.SetInt32("staffTempUserId", tempUserId);

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff(StaffVM vm)
        {
            var addedStaffInt = await _adminRepo.AddStaff(vm);

            var staffTypeId = vm.StaffTypeID;
            var staffTypeName = (await _adminRepo.GetStaffTypeById(vm.StaffTypeID)).Type;
            dynamic obj = null;
            string nextViewName = "Add" + staffTypeName;

            switch (staffTypeName)
            {
                case nameof(Pilot):
                    obj = new Pilot
                    {
                        StaffID = addedStaffInt
                    };
                    break;
                case nameof(Steward):
                    obj = new Steward
                    {
                        StaffID = addedStaffInt
                    };
                    break;
                default:
                    break;
            }

            return View(nextViewName, obj);
        }

        [HttpPost]
        public async Task<IActionResult> AddPilot(Pilot staff)
        {
            await _adminRepo.AddPilot(staff);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> AddSteward(Steward staff)
        {
            await _adminRepo.AddSteward(staff);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> EditStaff(int id)
        {

            return View();
        }

        public async Task<IActionResult> EditStaffRole(int id)
        {
            var userid = await _adminRepo.GetUserIdByStaffId(id);
            var results = await _adminRepo.GetUserRoleByUserid(userid);
            var rolesList = await _adminRepo.GetAllRoles();
            results.RolesList = (await _adminRepo.GetAllRoles()).Select(s => new SelectListItem { Text = s.Name, Value = s.Id.ToString() }).ToList();
            return View(results);
        }

        [HttpPost]
        public async Task<IActionResult> EditStaffRole(UserAndRole input)
        {
            await _adminRepo.UpdateUserAndRole(input);
            return RedirectToAction(nameof(ViewAllStaffs));
        }

        [HttpPost]
        public async Task<IActionResult> SetRole()
        {
            return View();
        }

        #endregion


        #region HandleBookings

        public async Task<IActionResult> ViewAllFlightGuests(int flightId)
        {
            return View();
        }

        #endregion
    }
}