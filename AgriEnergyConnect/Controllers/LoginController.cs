using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnect.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(string selectedRole)
        {
            if (selectedRole == "Farmer")
            {
                return RedirectToAction("FarmerLogin", "Account");
            }
            else if (selectedRole == "Employee")
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}
