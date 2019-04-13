using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlyAir.Data.IRepositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlyAir.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class dummyController : Controller
    {
        private readonly IdummyRepo _dummyRepo;

        public dummyController(IdummyRepo dummyRepo)
        {
            _dummyRepo = dummyRepo;
        }

        public async Task<IActionResult> Index()
        {
            var results = await _dummyRepo.GetAll();
            return View();
        }

        [Authorize]
        public IActionResult TestChat()
        {
            return View();
        }

        public IActionResult TestUpdateBooking()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> TestUpdateBooking2()
        {
            var results = await _dummyRepo.GetSqlTblDep();
            return Json(results);
        }

    }
}