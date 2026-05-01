using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ProjectRepository _repo;

        public PortfolioController(ProjectRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var projects = _repo.GetAll();
            return View(projects);
        }

        public IActionResult Details(string slug)
        {
            var project = _repo.GetBySlug(slug);
            if (project == null) return NotFound();
            return View(project);
        }
    }
}
