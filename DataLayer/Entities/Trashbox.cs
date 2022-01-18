﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Trashbox
    {
        [Required]
        [Key]
        public Guid TrashboxId { get; set; }
        public int Sum { get; set; }
        public User user { get; set; }
    }
}
