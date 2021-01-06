using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHBookStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
