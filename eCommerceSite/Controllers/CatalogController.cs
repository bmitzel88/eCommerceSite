using eCommerceSite.Data;
using eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


namespace eCommerceSite.Controllers
{
    public class CatalogController : Controller
    {
        private readonly VintageContext _context;



        public CatalogController(VintageContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Shop()
        {
            // Get all products from the database
            List<Product> products = _context.Products.ToList();
            
            
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }


        public async Task<IActionResult> Edit(int id) // This ID was set to the product in the CatalogController
        {
            Product? productToEdit = await _context.Products.FindAsync(id);

            if (productToEdit == null) 
            {
                return NotFound();
            }
            return View(productToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);    // prepares insert
                await _context.SaveChangesAsync(); // Executes pending insert

                // Show success message on page
                ViewData["Message"] = $"{product.Title} was added successfully!";
                return View();
            }

            return View(product);

        }




    }
}
