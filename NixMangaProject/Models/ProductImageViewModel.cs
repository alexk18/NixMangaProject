using System.Collections.Generic;
using NixMangaProject.EF.Models;
namespace NixMangaProject.Models
{
    public class ProductImageViewModel
    {
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Image> images { get; set; }
    }
}
