using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnect.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Username == user.Username))
                {
                    ModelState.AddModelError("", "Username already exists.");
                    return View();
                }

                user.Role = "Employee";

                _context.Users.Add(user);
                _context.SaveChanges();

                Console.WriteLine($"Saved user: {user.Username}, Password: {user.Password}, Role: {user.Role}");

                TempData["Message"] = "Registration successful. Please log in.";
                return RedirectToAction("Login");
            }

            return View(user);
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid username or password.";
                return View();
            }

            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("Role", user.Role);

            if (user.Role == "Employee")
                return RedirectToAction("Index", "EmployeeDashboard");
            else
                return RedirectToAction("Index", "FarmerDashboard");
        }

        [HttpGet]
        public IActionResult FarmerLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FarmerLogin(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password && u.Role == "Farmer");

            if (user == null)
            {
                ViewBag.Error = "Invalid login.";
                return View();
            }

            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("Role", user.Role);

            return RedirectToAction("Index", "FarmerDashboard");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
