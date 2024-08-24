
namespace SportsStore.Models
{
	public class EFProductRepository : IProductRepository
	{
		private ApplicationDbContext context;
		public EFProductRepository(ApplicationDbContext _context)
		{ 
			context = _context;
		}
		public IQueryable<Product> Products => context.Products;
	}
}

