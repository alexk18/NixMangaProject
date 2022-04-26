using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("User")]
    public partial class User
    {
        public User()
        {
            HistoryOrders = new HashSet<HistoryOrder>();
            Reviews = new HashSet<Review>();
            TrashboxProductUsers = new HashSet<TrashboxProductUser>();
        }

        [Key]
        public Guid UserId { get; set; }
        [StringLength(50)]
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Adress { get; set; }
        public string Email { get; set; } = null!;
        public string MobilePhone { get; set; } = null!;
        public Guid TrashboxId { get; set; }
        public Guid ProductId { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<HistoryOrder> HistoryOrders { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Review> Reviews { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<TrashboxProductUser> TrashboxProductUsers { get; set; }
    }
}
