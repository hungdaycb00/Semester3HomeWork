using MHBookStore.Models;
using MHBookStore.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MHBookStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 10;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        //public IActionResult Index() => View(repository.Books);

        public ViewResult Index(string category,int productPage = 1)
            => View(new ProductsListViewModel
            {
                Books = repository.Books
                        .Where(p => category == null || p.Category == category) //kiểm tra category
                        .OrderBy(p => p.Id)
                        .Skip((productPage - 1) * PageSize) //skip: bỏ qua, take: lấy
                        .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Books.Count()
                }
            });

        public IActionResult Detail() => View();
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
