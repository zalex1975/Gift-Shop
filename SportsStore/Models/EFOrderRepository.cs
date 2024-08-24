
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
	public class EFOrderRepository : IOrderRepository
	{
		private ApplicationDbContext context;
		public EFOrderRepository(ApplicationDbContext _context)
		{
			context = _context;
		}

		public IQueryable<Order> Orders => context.Orders
												  .Include(x=>x.Lines)
											      .ThenInclude(x=>x.Product);
		public void SaveOrder(Order order)
		{
			context.AttachRange(order.Lines.Select(x => x.Product));
			if (order.OrderID == 0)
			{
				context.Orders.Add(order);
			}
			context.SaveChanges();
		}
	}
}
