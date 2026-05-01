using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactMessage model)
        {
            if (ModelState.IsValid)
            {
                TempData["Success"] = "Thank you for reaching out. I'll be in touch shortly.";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
