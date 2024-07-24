using Microsoft.AspNetCore.Mvc;

namespace eCommerceSite.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
    }
}
