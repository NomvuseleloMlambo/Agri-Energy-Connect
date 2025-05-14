using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AgriEnergyConnect.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product, IFormFile? productImage)
        {
            if (ModelState.IsValid)
            {
                product.FarmerUsername = HttpContext.Session.GetString("Username");

                if (productImage != null && productImage.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(productImage.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        productImage.CopyTo(stream);
                    }

                    product.ImageFileName = fileName;
                }

                Console.WriteLine("Saving product: " + product.Name);
                _context.Products.Add(product);
                _context.SaveChanges();


                TempData["Message"] = "Product added successfully!";
                return RedirectToAction("Index", "FarmerDashboard");
            }
            else
            {
                Console.WriteLine("ModelState is NOT valid");
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        Console.WriteLine("Validation error: " + error.ErrorMessage);
                    }
                }
            }

            return View();
        }


        [HttpGet]
        public IActionResult ViewMyProducts()
        {
            var username = HttpContext.Session.GetString("Username");
            var products = _context.Products
                .Where(p => p.FarmerUsername == username)
                .ToList();

            return View(products);
        }

        [HttpGet]
        public IActionResult AllProducts(string category, DateTime? fromDate, DateTime? toDate, string farmerUsername)
        {
            var products = _context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category.ToLower().Contains(category.ToLower()));
            }

            if (!string.IsNullOrEmpty(farmerUsername))
            {
                products = products.Where(p => p.FarmerUsername.ToLower().Contains(farmerUsername.ToLower()));
            }

            if (fromDate.HasValue)
            {
                products = products.Where(p => p.ProductionDate >= fromDate.Value);
            }

            if (toDate.HasValue)
            {
                products = products.Where(p => p.ProductionDate <= toDate.Value);
            }

            return View(products.ToList());
        }
    }
}
