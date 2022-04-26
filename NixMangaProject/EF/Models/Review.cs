using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("Review")]
    public partial class Review
    {
        [Key]
        public Guid ReviewId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime ReviewDate { get; set; }
        public string ReviewDescription { get; set; } = null!;
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("Reviews")]
        public virtual Product Product { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("Reviews")]
        public virtual User User { get; set; } = null!;
    }
}
