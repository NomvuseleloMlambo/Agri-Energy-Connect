using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnect.Controllers
{
    public class FarmerDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
