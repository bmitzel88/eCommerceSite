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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginModel)
        {
            if (ModelState.IsValid)
            {
                // Check DB for credentials
                Member? m = (from member in _context.Members
                           where member.Email == loginModel.Email && 
                                member.Password == loginModel.Password
                           select member).SingleOrDefault();
                
                // If exists send to home page loggin in
                if (m != null)
                {
                    HttpContext.Session.SetString("Email", loginModel.Email);
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("checkCredentials", "Credentials not found");
            }
            // Return page if no record found
            return View(loginModel);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        
    }
}
