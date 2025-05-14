using Microsoft.AspNetCore.Mvc;
using AgriEnergyConnect.Models;

namespace AgriEnergyConnect.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ForumController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Role") != "Farmer")
                return RedirectToAction("Login", "Account");

            var posts = _context.ForumPosts
                                .OrderByDescending(p => p.Timestamp)
                                .ToList();

            return View(posts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Role") != "Farmer")
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpPost]
        public IActionResult Create(ForumPost post)
        {
            if (HttpContext.Session.GetString("Role") != "Farmer")
                return RedirectToAction("Login", "Account");

            if (ModelState.IsValid)
            {
                post.AuthorUsername = HttpContext.Session.GetString("Username");
                post.Timestamp = DateTime.Now;

                _context.ForumPosts.Add(post);
                _context.SaveChanges();

                TempData["Message"] = "Post submitted successfully!";
                return RedirectToAction("Index");
            }

            return View(post);
        }
    }
}
