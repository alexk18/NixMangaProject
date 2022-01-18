using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Genre
    {
        [Required(ErrorMessage = "Укажите айди товара")]
        [Key]
        public Guid GenreId { get; set; }
        [Required(ErrorMessage = "Укажите название жанра")]
        [StringLength(15)]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> products { get; set; }
    }
}
