using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            HistoryOrders = new HashSet<HistoryOrder>();
            Images = new HashSet<Image>();
            ProductGenres = new HashSet<ProductGenre>();
            Reviews = new HashSet<Review>();
            TrashboxProductUsers = new HashSet<TrashboxProductUser>();
        }

        [Key]
        public Guid ProductId { get; set; }
        public string ProductDescription { get; set; } = null!;
        [Column(TypeName = "money")]
        public decimal ProductCost { get; set; }
        public bool ProductAviable { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; } = null!;
        public Guid PublisherId { get; set; }

        [ForeignKey("PublisherId")]
        [InverseProperty("Products")]
        public virtual Publisher Publisher { get; set; } = null!;
        [InverseProperty("Product")]
        public virtual ICollection<HistoryOrder> HistoryOrders { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<Image> Images { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<ProductGenre> ProductGenres { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<Review> Reviews { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<TrashboxProductUser> TrashboxProductUsers { get; set; }
    }
}
