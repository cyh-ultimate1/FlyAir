using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using FlyAir.Data.IRepositories;
using FlyAir.Hubs;
using FlyAir.Models.FlightModels;
using FlyAir.Models.SearchModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using mySession.Data.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FlyAir.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class FlightController : Controller
    {
        private readonly ICountryRepo _countryRepo;
        private readonly IFlightRepo _flightRepo;
        private readonly IGlobalRepo _globalRepo;
        private readonly IBookingRepo _bookingRepo;
        private readonly IHubContext<BookingHub> _bookingHub;

        public FlightController(ICountryRepo countryRepo, IFlightRepo flightRepo, IGlobalRepo globalRepo, IHubContext<BookingHub> bookingHub, IBookingRepo bookingRepo)
        {
            _countryRepo = countryRepo;
            _flightRepo = flightRepo;
            _globalRepo = globalRepo;
            _bookingRepo = bookingRepo;
            _bookingHub = bookingHub;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SearchFlight(SearchFlight vm)
        {
            //var to keep search input for flight results use
            var searchFlightTemp = new SearchFlight
            {
                OriginID = vm.OriginID,
                DestID = vm.DestID,
                WaySelection = vm.WaySelection,
                DepartDate = vm.DepartDate,
                ReturnDate = vm.ReturnDate
            };
            _globalRepo.SaveObjToSessionJSON<SearchFlight>("searchFlightTemp", searchFlightTemp);

            HttpContext.Session.SetInt32("adultNum", vm.AdultNum);
            HttpContext.Session.SetInt32("childrenNum", vm.ChildrenNum);

            //get the result of search input
            var result = await _flightRepo.GetBySearchInput(vm);

            //subscribe to signalR real time update of item addition to Booking Table
            //_bookingRepo.subscribeBookingAdd();

            //copy and bring over variables needed for next view
            result.OriginName = vm.OriginName;
            result.DestName = vm.DestName;

            return View("FlightResults", result);
        }

        [HttpPost]
        public async Task<IActionResult> SearchFlightShort([FromBody]JObject reqData)
        {
            try
            {
                //get current search flight inputs and replace with new dates
                var searchFlightTemp = _globalRepo.GetObjFromSessionJSON<SearchFlight>("searchFlightTemp"); 
                searchFlightTemp.DepartDate = _globalRepo.GetJObjVar<DateTime>(reqData, "departDate");
                searchFlightTemp.ReturnDate = _globalRepo.GetJObjVar<DateTime>(reqData, "returnDate");
                
                //get results of search input
                var result = await _flightRepo.GetBySearchInput(searchFlightTemp);
                result.adjustGoFlight = _globalRepo.GetJObjVar<bool>(reqData, "toAdjustGoFlight");

                //re-save the search Flight inputs to session variable.
                _globalRepo.SaveObjToSessionJSON<SearchFlight>("searchFlightTemp", searchFlightTemp);

                //if result is not null or empty, return partial view
                if (result != null)
                {
                    return PartialView("_FlightResultsPartial", result);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public IActionResult ViewApiFlights()
        {
            return View("apiFlightsView");
        }
    }
}