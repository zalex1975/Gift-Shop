using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IProductRepository _repository;
        public NavigationMenuViewComponent(IProductRepository repo) => _repository = repo;
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            var list = _repository.Products.Select(x => x.Category).Distinct().OrderBy(x => x);
            return View(list);
        }
    }
}
