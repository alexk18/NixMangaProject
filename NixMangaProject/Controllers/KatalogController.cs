using Microsoft.AspNetCore.Mvc;

namespace NixMangaProject.Controllers
{
    public class KatalogController : Controller
    {
        //[Route("Test")]
        public IActionResult Prosmotr()
        {
            return View();
        }
    }
}
