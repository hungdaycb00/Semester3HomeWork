using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MHBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

    }
}
