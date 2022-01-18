﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Image
    {
        [Required]
        [Key]
        public Guid ImageId { get; set; }
        public string Name { get; set; }
    }
}
