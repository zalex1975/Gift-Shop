using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class OrderController : Controller
    {
        private Cart cart;
        private IOrderRepository repository;
        
        public OrderController (IOrderRepository _repository,  Cart _cart)
        {
            repository = _repository;
			cart = _cart;
        }
		[HttpGet]
		public ViewResult Checkout() => View(new Order());

        [HttpDelete]
		public IActionResult Checkout(string ID) => Content($"типо удалил конкретный ID {ID}");
		
		[HttpPost]
        public IActionResult Checkout(Order order) {
			
			//return Content("типо сохранил");
			if (cart.Lines.Count() == 0) {
                ModelState.AddModelError("", "Ваша корзина пустая");
            }

            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
				repository.SaveOrder(order);                        // save BD
				return RedirectToAction(nameof(Completed));
            }
            else
                return View(order);
		}
        public ViewResult Completed()
        {
            ViewData["sum"] = cart.ComputeTotalValue();
            cart.Clear();
            return View();
        }
    }
}
