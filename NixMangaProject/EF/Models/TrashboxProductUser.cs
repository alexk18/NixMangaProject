using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("TrashboxProductUser")]
    public partial class TrashboxProductUser
    {
        [Key]
        public Guid SpecialId { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public Guid TrashboxId { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("TrashboxProductUsers")]
        public virtual Product Product { get; set; } = null!;
        [ForeignKey("TrashboxId")]
        [InverseProperty("TrashboxProductUsers")]
        public virtual Trashbox Trashbox { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("TrashboxProductUsers")]
        public virtual User User { get; set; } = null!;
    }
}
