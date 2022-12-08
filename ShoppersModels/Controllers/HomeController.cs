using Microsoft.AspNetCore.Mvc;
using ShoppersModels.Models;

namespace ShoppersModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 0,
                    Name = "Tank Top",
                    Description = "Finding perfect t-shirt",
                    Price = 50,
                    ImageUrl = "cloth_1.jpg"
                },
                new Product
                {
                    Id = 1,
                    Name = "Corater",
                    Description = "Finding perfect products",
                    Price = 50,
                    ImageUrl = "shoe_1.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Polo Shirt",
                    Description = "Finding perfect products",
                    Price = 50,
                    ImageUrl = "cloth_2.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "T-Shirt Mockup",
                    Description = "Finding perfect products",
                    Price = 50,
                    ImageUrl = "cloth_3.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Corater",
                    Description = "Finding perfect products",
                    Price = 50,
                    ImageUrl = "shoe_1.jpg"
                }
            };

            var model = new HomeViewModel
            { 
                Products = products
            };

            return View(model);
        }
    }
}
