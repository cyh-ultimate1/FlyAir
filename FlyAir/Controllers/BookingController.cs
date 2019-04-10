using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyAir.Data.IRepositories;
using FlyAir.Models.BookingModels;
using FlyAir.Models.IdentityEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using mySession.Data.Extensions;

namespace FlyAir.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class BookingController : Controller
    {
        private readonly ICountryRepo _countryRepo;
        private readonly IFlightRepo _flightRepo;
        private readonly IBookingRepo _bookingRepo;
        private readonly IGlobalRepo _globalRepo;
        private readonly UserManager<CustomUser> _userManager;
        private readonly SignInManager<CustomUser> _signInManager;

        public BookingController(ICountryRepo countryRepo, IFlightRepo flightRepo, UserManager<CustomUser> userManager,
            SignInManager<CustomUser> signInManager, IBookingRepo bookingRepo,
            IGlobalRepo globalRepo)
        {
            _countryRepo = countryRepo;
            _flightRepo = flightRepo;
            _userManager = userManager;
            _signInManager = signInManager;
            _bookingRepo = bookingRepo;
            _globalRepo = globalRepo;
        }

        //http post when flight is selected. If no return flight selected, default to null
        [HttpPost]
        public async Task<IActionResult> SelectFlight(string oneIdSelGo, string oneIdSelRet = null)
        {
            var tempBooking = new Booking
            {
                GoFlightId = Convert.ToInt32(oneIdSelGo)
            };
            tempBooking.GoFlight = await _flightRepo.GetByFlightId(tempBooking.GoFlightId);
            tempBooking.GoFlight.OriginLoc1 = await _countryRepo.GetLocById(tempBooking.GoFlight.OriginLocID);
            tempBooking.GoFlight.DestLoc1 = await _countryRepo.GetLocById(tempBooking.GoFlight.DestLocID);

            if (oneIdSelRet != null)
            {
                tempBooking.ReturnFlightId = Convert.ToInt32(oneIdSelRet);
                tempBooking.ReturnFlight = await _flightRepo.GetByFlightId(tempBooking.ReturnFlightId);
                tempBooking.ReturnFlight.OriginLoc1 = await _countryRepo.GetLocById(tempBooking.ReturnFlight.OriginLocID);
                tempBooking.ReturnFlight.DestLoc1 = await _countryRepo.GetLocById(tempBooking.ReturnFlight.DestLocID);
            }

            //create BookingVM object to create new booking guests property. Booking property is not assigned to facilitate form submission in next action.
            var tempBookingVM = new BookingVM
            {
                BookingNonMembers = new List<BookingNonMember>()
            };

            var adultNum = HttpContext.Session.GetInt32("adultNum");
            var childrenNum = HttpContext.Session.GetInt32("childrenNum");

            for (byte i = 0; i < adultNum; i++)
            {
                tempBookingVM.BookingNonMembers.Add(new BookingNonMember());
            }
            for (byte i = 0; i < childrenNum; i++)
            {
                tempBookingVM.BookingNonMembers.Add(new BookingNonMember());
            }

            //save tempBooking to session var.
            _globalRepo.SaveObjToSessionJSON<Booking>("tempBookingDetails", tempBooking);

            return View("FillInBookingDetails", tempBookingVM);
        }

        public IActionResult GoToFillInBookingDetails()
        {
            //get all filled in data from session variable and return to form view.
            var vm = _globalRepo.GetObjFromSessionJSON<BookingVM>("tempBookingVMDetails");
            return View("FillInBookingDetails", vm);
        }

        [HttpPost]
        public async Task<IActionResult> PostUserInfo(BookingVM vm)
        {
            ////get tempBookingDetails and save to tempBookingVMDetails
            var tempBooking = _globalRepo.GetObjFromSessionJSON<Booking>("tempBookingDetails");
            vm.Booking = tempBooking;

            ////SessionHelper.SetObjectAsJson<BookingVM>(HttpContext.Session, "tempBookingVMDetails", vm);
            _globalRepo.SaveObjToSessionJSON<BookingVM>("tempBookingVMDetails", vm);

            return View("ConfirmBooking");
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmBooking()
        {
            //get session variable tempBookingVMDetails
            var bookingVM = _globalRepo.GetObjFromSessionJSON<BookingVM>("tempBookingVMDetails");

            //if non member make booking, set currUserId as null
            string currUserId = null;
            if (_signInManager.IsSignedIn(User))
            {
                currUserId = _userManager.GetUserId(User);
            }
            //add booking to DB and get add booking Id
            var resultId = await _bookingRepo.AddBooking(bookingVM.Booking, currUserId);

            //get all booking guests details and add to DB
            foreach(var guest in bookingVM.BookingNonMembers)
            {
                await _bookingRepo.AddBookingGuests(guest, resultId);
            }

            //update seats remain count. Assume every booking guest will result in one seat reserved, regardless whether they have checked in
            await _flightRepo.UpdateSeatsRemain(-bookingVM.BookingNonMembers.Count(), bookingVM.Booking.GoFlightId);
            await _flightRepo.UpdateSeatsRemain(-bookingVM.BookingNonMembers.Count(), bookingVM.Booking.ReturnFlightId);

            //copy added booking ID to vm
            bookingVM.Booking.ID = resultId;

            //remove session variables to release memory
            HttpContext.Session.Remove("tempBookingVMDetails");
            HttpContext.Session.Remove("tempBookingDetails");

            //return the VM to next view for display purposes
            return View("BookingConfirmed", bookingVM);
        }

        #region MembersOnly

        [Authorize]
        public async Task<IActionResult> GetMemberBookings()
        {
            //get bookings of current user
            var bookings = (await _bookingRepo.GetMemberBookings(_globalRepo.GetCurrentUserId().ToString())).ToList();

            //merge all flightIds and get all related flights and location details.
            var flightIds = bookings.Select(s => s.GoFlightId).Concat(bookings.Select(s => s.ReturnFlightId)).Distinct();
            var flights = await _flightRepo.GetAllByFlightId(flightIds);
            var locIds = flights.Select(b => b.OriginLocID).Concat(flights.Select(b => b.DestLocID)).Distinct();
            var loc = await _countryRepo.GetAllLocById(locIds);

            //fill in details of all bookings for current user
            for (int idx = 0; idx < bookings.Count(); idx++)
            {
                bookings[idx].GoFlight = flights.Single(s => s.ID == bookings[idx].GoFlightId);
                bookings[idx].GoFlight.OriginLoc = loc.Single(c => c.ID == bookings[idx].GoFlight.OriginLocID);
                bookings[idx].GoFlight.DestLoc = loc.Single(c => c.ID == bookings[idx].GoFlight.DestLocID);
                if(bookings[idx].ReturnFlightId > 0)
                {
                    bookings[idx].ReturnFlight = flights.Single(s => s.ID == bookings[idx].ReturnFlightId);
                    bookings[idx].ReturnFlight.OriginLoc = loc.Single(c => c.ID == bookings[idx].ReturnFlight.OriginLocID);
                    bookings[idx].ReturnFlight.DestLoc = loc.Single(c => c.ID == bookings[idx].ReturnFlight.DestLocID);
                }
            }
            return View(bookings.OrderByDescending(b=>b.ID));
        }

        [HttpPost]
        public async Task<IActionResult> WebCheckIn(int bookingId = 0)
        {
            if(bookingId == 0)
            {
                var currUserId = _globalRepo.GetCurrentUserId().ToString();
            }
            //save bookingId to session
            _globalRepo.SaveObjToSessionJSON<int>("tempBookingId", bookingId);
            var bookingvm = await _bookingRepo.GetBookingWGuestsById(bookingId);
            var booking = bookingvm.Booking;    //only use if no value is intended to be changed

            //fill in flight details of the booking
            bookingvm.Booking.GoFlight = await _flightRepo.GetByFlightId(booking.GoFlightId);
            bookingvm.Booking.GoFlight.OriginLoc1 = await _countryRepo.GetLocById(booking.GoFlight.OriginLocID);
            bookingvm.Booking.GoFlight.DestLoc1 = await _countryRepo.GetLocById(booking.GoFlight.DestLocID);
            bookingvm.Booking.GoFlight.FlightSeatType = await _flightRepo.GetFlightSeatTypeById(booking.GoFlight.FlightSeatTypeID);

            //if there is return flight, fill in flight details of return flight to booking
            if(booking.ReturnFlightId > 0)
            {
                bookingvm.Booking.ReturnFlight = await _flightRepo.GetByFlightId(booking.ReturnFlightId);
                bookingvm.Booking.ReturnFlight.OriginLoc1 = await _countryRepo.GetLocById(booking.ReturnFlight.OriginLocID);
                bookingvm.Booking.ReturnFlight.DestLoc1 = await _countryRepo.GetLocById(booking.ReturnFlight.DestLocID);
                bookingvm.Booking.ReturnFlight.FlightSeatType = await _flightRepo.GetFlightSeatTypeById(booking.ReturnFlight.FlightSeatTypeID);
            }

            //to retrieve flight seats
            var seatsTakenGoFlight = await _bookingRepo.GetSeatsTakenByFlightId(booking.GoFlightId, true);
            var seatsTakenReturnFlight = await _bookingRepo.GetSeatsTakenByFlightId(booking.ReturnFlightId, false);

            //create vm to pass to view
            var vm = new SelectSeatViewVM
            {
                Booking = bookingvm.Booking,
                BookingNonMembersList = bookingvm.BookingNonMembers,
                SeatsTakenGoFlight = seatsTakenGoFlight.ToList(),
                SeatsTakenReturnFlight = seatsTakenReturnFlight.ToList()
            };

            return View("SelectSeatView", vm);
        }

        //http post after seat selected
        [HttpPost]
        public async Task<IActionResult> SeatSelected(SelectSeatViewVM vm)
        {
            foreach(var guest in vm.BookingNonMembersList)
            {
                await _bookingRepo.UpdateGuestsSeats(guest);
            }
            await _bookingRepo.UpdateHasCheckedIn(vm.BookingNonMembersList[0].BookingID);
            return RedirectToAction(nameof(GetMemberBookings));
        }


        #endregion
    }
}