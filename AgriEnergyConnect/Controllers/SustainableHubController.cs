using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnect.Controllers
{
    public class SustainableHubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
