using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("Trashbox")]
    public partial class Trashbox
    {
        public Trashbox()
        {
            TrashboxProductUsers = new HashSet<TrashboxProductUser>();
        }

        [Key]
        public Guid TrashboxId { get; set; }
        [Column(TypeName = "money")]
        public decimal Sum { get; set; }
        public short ElementCount { get; set; }

        [InverseProperty("Trashbox")]
        public virtual ICollection<TrashboxProductUser> TrashboxProductUsers { get; set; }
    }
}
