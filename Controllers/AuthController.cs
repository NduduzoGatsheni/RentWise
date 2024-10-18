using Microsoft.AspNetCore.Mvc;

namespace RentWise.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "password123")
            {
                // Redirect to home page if login is successful
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid credentials. Please try again.";
                return View();
            }
        }
    }
}

        

        // POST: /Auth/Login


