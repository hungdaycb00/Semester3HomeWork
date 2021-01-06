using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHBookStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
