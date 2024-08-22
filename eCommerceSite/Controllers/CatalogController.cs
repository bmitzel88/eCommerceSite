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


        [HttpGet]
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
        public async Task<IActionResult> Edit(Product productModel)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(productModel);
                await _context.SaveChangesAsync();

                TempData["Message"] = $"{productModel.Title} was updated successfully";
                return RedirectToAction("Shop");
            }

            return View(productModel);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Product productToDelete = await _context.Products.FindAsync(id);

            if (productToDelete == null)
            {
                return NotFound();
            }

            return View(productToDelete);
        }


        [HttpPost, ActionName("Delete")] // This to get around not posting and C# syntax
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            Product productToDelete = await _context.Products.FindAsync(id);

            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                await _context.SaveChangesAsync();
                TempData["Message"] = productToDelete.Title + " was deleted successfully";

                return RedirectToAction("Shop");
            }

            TempData["Message"] = " This product was already deleted";
            return RedirectToAction("Shop");
        }


        public async Task<IActionResult> Details(int id)
        {
            Product productDetails = await _context.Products.FindAsync(id);

            if (productDetails == null)
            {
                return NotFound();
            }


            return View(productDetails);
        }
    }
}
