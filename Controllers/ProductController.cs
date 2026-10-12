using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical6.Models;

namespace Practical6.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = GetProducts();

            return View(products);
        }

        // Product list
        private List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            // Product 1 - Laptop
            Product p1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 50000,
                Category = "Electronics",
                ImgURL = "https://example.com/laptop.jpg",
                Description = "A high-performance laptop for students."
            };

            // Product 2 - Smartphone
            Product p2 = new Product
            {
                Id = 2,
                Name = "Smartphone",
                Price = 30000,
                Category = "Electronics",
                ImgURL = "https://example.com/smartphone.jpg",
                Description = "A modern smartphone with advanced features."
            };

            // Product 3 - Headphones
            Product p3 = new Product
            {
                Id = 3,
                Name = "Headphones",
                Price = 5000,
                Category = "Accessories",
                ImgURL = "https://example.com/headphones.jpg",
                Description = "Wireless headphones with high-quality sound."
            };

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return products;
        }

        // GET: Product/Details/1
        public ActionResult Details(int id)
        {
            List<Product> products = GetProducts();

            Product product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }
    }
}