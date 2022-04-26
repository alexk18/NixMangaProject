using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("ProductGenre")]
    public partial class ProductGenre
    {
        [Key]
        [Column("GenProID")]
        public Guid GenProId { get; set; }
        public byte GenreId { get; set; }
        public Guid ProductId { get; set; }

        [ForeignKey("GenreId")]
        [InverseProperty("ProductGenres")]
        public virtual Genre Genre { get; set; } = null!;
        [ForeignKey("ProductId")]
        [InverseProperty("ProductGenres")]
        public virtual Product Product { get; set; } = null!;
    }
}
