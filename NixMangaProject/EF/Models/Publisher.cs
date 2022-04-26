using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NixMangaProject.EF.Models
{
    [Table("Publisher")]
    public partial class Publisher
    {
        public Publisher()
        {
            Products = new HashSet<Product>();
        }
        public Publisher(string name, string description, string contact)
        {
            this.PublisherId = new Guid();
            this.PublisherName = name;
            this.PublisherDescription = description;
            this.ContactInfo = contact;
        }
        [Key]
        public Guid PublisherId { get; set; }
        [StringLength(50)]
        public string PublisherName { get; set; } = null!;
        public string PublisherDescription { get; set; } = null!;
        public string ContactInfo { get; set; } = null!;

        [InverseProperty("Publisher")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
