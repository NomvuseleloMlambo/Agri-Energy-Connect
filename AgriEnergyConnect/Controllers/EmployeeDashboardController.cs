using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnect.Controllers
{
    public class EmployeeDashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeDashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddFarmer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFarmer(string username, string password)
        {
            if (_context.Users.Any(u => u.Username == username))
            {
                ViewBag.Error = "Username already exists.";
                return View();
            }

            var farmer = new User
            {
                Username = username,
                Password = password,
                Role = "Farmer"
            };

            _context.Users.Add(farmer);
            _context.SaveChanges();

            TempData["Message"] = "Farmer added successfully!";
            return RedirectToAction("Index", "EmployeeDashboard");
        }

    }
}
