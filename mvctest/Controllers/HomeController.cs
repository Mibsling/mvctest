using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvctest.Models;

namespace mvctest.Controllers
{
    public class HomeController : Controller
    {
        private readonly TravelExpertsContext _context;
        public IActionResult Index()
        {
            return View();
        }

        public HomeController(TravelExpertsContext context)
        {
            _context = context;
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult LogOut()
        {
            ViewData["Message"] = "Logged out -- Main page.";
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Registration()
        {
            ViewData["Message"] = "Your registration page.";

            return View();
        }

        public async Task<IActionResult> Packages()
        {
            return View(await _context.Packages.ToListAsync());
        }

        public async Task<IActionResult> Bookings()
        {
            return View(await _context.Bookings.ToListAsync());
        }

        public async Task<IActionResult> Agencies()
        {
            return View(await _context.Agencies.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
