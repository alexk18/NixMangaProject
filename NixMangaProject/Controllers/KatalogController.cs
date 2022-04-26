using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NixMangaProject.EF;
using NixMangaProject.EF.Models;
using NixMangaProject.Models;

namespace NixMangaProject.Controllers
{
    public class KatalogController : Controller
    {
        private readonly ManhaShopDbContext _context;

        public KatalogController(ManhaShopDbContext _context)
        {
            this._context = _context;
        }
        
        public async Task<IActionResult> Prosmotr(string sortOrder,string searchString, int pg=1)
        {
            ViewData["Filter"] = sortOrder;
            ViewData["CurrentFilter"] = searchString;
            var product = from p in _context.Products select p;
            switch (sortOrder)
            {
                case "aviable":
                    product = product.OrderByDescending(s => s.ProductAviable);
                    break;
                case "downTohight":
                    product = product.OrderBy(s => s.ProductCost);
                    break;
                case "HightToDown":
                    product = product.OrderByDescending(s => s.ProductCost);
                    break;
                default:
                    product = product.OrderBy(s => s.ProductName);
                    break;
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                product = product.Where(s => s.ProductName.Contains(searchString));
            }
            List<Product> products = await product.AsNoTracking().ToListAsync();
            const int pageSize = 3;
            if (pg < 1) { pg = 1; }
            int rescCount = products.Count();
            var pager = new Pager(rescCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = products.Skip(recSkip).Take(pager.PageSize).ToList();
            var img = _context.Images.ToList();
            ProductImageViewModel PrIg = new ProductImageViewModel { products = data , images = img};
            this.ViewBag.Pager = pager;
            return View(PrIg);
        }
    }
}
