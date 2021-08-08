using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Online_Booking_Tourism.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Online_Booking_Tourism.Controllers
{
    public class HomeController : Controller
    {


        private readonly ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Hotels()
        {
            var hotels = await _context.Hotels.ToListAsync();
            return View(hotels);
        }
        [Authorize]
        public async Task<IActionResult> Admins()
        {
            var admins = await _context.Admins.ToListAsync();
            return View(admins);
        }
        [Authorize]
        public async Task<IActionResult> Guiders()
        {
            var guiders = await _context.Guiders.ToListAsync();
            return View(guiders);
        }
        [Authorize]
        public async Task<IActionResult> Travelers()
        {
            var travelers = await _context.Travelers.ToListAsync();
            return View(travelers);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
