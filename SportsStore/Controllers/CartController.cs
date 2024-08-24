using Microsoft.AspNetCore.Mvc;
using SportsStore.Infrastructure;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository _repository;
        public CartController(IProductRepository repo) => _repository = repo;
        public ViewResult Index(string returnUrl)
        {
            return View( new CartIndexViewModel { Cart = GetGart(), ReturnUrl = returnUrl});
        }
        public RedirectToActionResult AddToCart (int productID, string returnUrl)
        {
            var currentProduct = _repository.Products.FirstOrDefault(x => x.ProductId == productID);
            if (currentProduct != null) 
            {
                Cart cart = GetGart();
                cart.AddItem(currentProduct, 1);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl) {
            var currentProduct = _repository.Products.FirstOrDefault(x => x.ProductId == productID);
            if (currentProduct != null)
            {
                Cart cart = GetGart();
                cart.RemoveItem(currentProduct);
                SaveCart(cart);
            }
            return RedirectToAction("Index", new { returnUrl });

        }
        private Cart GetGart() => HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        private void SaveCart(Cart cart) =>
            HttpContext.Session.SetJson("Cart", cart);
        
    }
}
