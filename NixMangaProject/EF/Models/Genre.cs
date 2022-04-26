using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("Genre")]
    public partial class Genre
    {
        public Genre()
        {
            ProductGenres = new HashSet<ProductGenre>();
        }

        [Key]
        public byte GenreId { get; set; }
        [StringLength(50)]
        public string GenreName { get; set; } = null!;
        public string GenreDescription { get; set; } = null!;

        [InverseProperty("Genre")]
        public virtual ICollection<ProductGenre> ProductGenres { get; set; }
    }
}
