using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("Image")]
    public partial class Image
    {
        [Key]
        public Guid ImageId { get; set; }
        public string ImgSource { get; set; } = null!;
        public string AltSource { get; set; } = null!;
        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("Images")]
        public virtual Product Product { get; set; } = null!;
    }
}
