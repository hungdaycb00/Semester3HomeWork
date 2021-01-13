using BookStore.Infrastructure;
using BookStore.Models;
using BookStore.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        private int pageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        //public IActionResult Index() => View();

        public ViewResult Index(int productPage = 1) => View(new ProductListViewModel
        {
            Books = repository.Books.OrderBy(p => p.BookId)
            .Skip((productPage - 1) * pageSize)
            .Take(pageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = pageSize,
                TotalItems = repository.Books.Count()
            }
        });
       
      

   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
