using Microsoft.AspNetCore.Mvc;
using NixMangaProject.EF;
using NixMangaProject.EF.Models;

namespace NixMangaProject.Controllers
{
    public class AddController : Controller
    {
        private readonly ManhaShopDbContext _context;

        public AddController(ManhaShopDbContext _context)
        {
            this._context = _context;
        }
        [HttpGet]
        public IActionResult AddPublisher()
        {
            return View();
        }
        [HttpPost]
        public void AddPublisher(string PublisherName, string PublisherDescription, string ContactInfo)
        {
            Publisher pub = new Publisher(PublisherName, PublisherDescription, ContactInfo);
            _context.Publishers.Add(pub);
            _context.SaveChanges();
        }
    }
}
