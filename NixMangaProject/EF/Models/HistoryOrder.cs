using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("HistoryOrder")]
    public partial class HistoryOrder
    {
        [Key]
        public Guid HistoryId { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        [StringLength(50)]
        public string Status { get; set; } = null!;

        [ForeignKey("ProductId")]
        [InverseProperty("HistoryOrders")]
        public virtual Product Product { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("HistoryOrders")]
        public virtual User User { get; set; } = null!;
    }
}
