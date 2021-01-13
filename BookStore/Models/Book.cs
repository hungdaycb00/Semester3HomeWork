﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
      
        public string Description { get; set; }
        [Column(TypeName ="decimal(8,2)")]
        public decimal Price { get; set; }
        [Column("Image")]
        public string UrlImage { get; set; }
    }
}
