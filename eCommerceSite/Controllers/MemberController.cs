using eCommerceSite.Data;
using eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceSite.Controllers
{
    public class MemberController : Controller
    {

        private readonly VintageContext _context;

        public MemberController(VintageContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel regModel)
        {
            // Map RegisterViewModel data to the Member object
            if (ModelState.IsValid)
            {
                Member member = new()
                {
                    Email = regModel.Email,
                    Password = regModel.Password
                };

                _context.Members.Add(member);
                await _context.SaveChangesAsync();


                // Redirect to the home page
                return RedirectToAction("Index", "Home");
            }

            return View(regModel);
        }
        
    }
}
