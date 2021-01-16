using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHBookStore.Models.ViewModel
{
    public class ProductsListViewModel
    {
        public IEnumerable<Book> Books { get; set; }

        public PagingInfo PagingInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}
