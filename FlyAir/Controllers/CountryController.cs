using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyAir.Data.IRepositories;
using FlyAir.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlyAir.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryRepo _countryRepo;

        public CountryController(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }

        [HttpGet]
        public async Task<JsonResult> GetSearchLocation(string reqData)
        {
            try
            {
                var result = await _countryRepo.GetLocByInput(reqData);
                if (result != null)
                {
                    return Json(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}