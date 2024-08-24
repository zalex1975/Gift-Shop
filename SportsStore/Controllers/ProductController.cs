using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System.Linq;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            _repository = repo;
        }
        public ViewResult List(string category, int productPage = 1)
            => View(new ProductListViewModel
            {
				Products = _repository.Products
                .Where(x=> category == null || x.Category == category)
                .OrderBy(x => x.ProductId)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems =  category == null 
                                    ? _repository.Products.Count() 
                                    : _repository.Products.Where(x=>x.Category == category).Count()
                },
                CurrentCategory = category
            });
    }
}
