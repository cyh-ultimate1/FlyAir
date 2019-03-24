using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyAir.Data.IRepositories;
using FlyAir.Hubs;
using FlyAir.Models.FlightModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FlyAir.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flight>>> GetAllFlights()
        {
            var results = await _globalRepo.GetAll<Flight>(Flight.tableName);

            if (results == null)
            {
                return NotFound();
            }

            return results.ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Flight>> GetFlight(int id)
        {
            var results = await _flightRepo.GetByFlightId(id);

            if (results == null)
            {
                return NotFound();
            }

            return results;
        }
    }
}