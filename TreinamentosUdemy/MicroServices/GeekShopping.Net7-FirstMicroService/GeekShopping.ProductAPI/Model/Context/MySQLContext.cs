using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
	public class MySQLContext : DbContext
	{
		public MySQLContext() { }

		public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// You don't actually ever need to call this
		}

		public DbSet<Product> Products { get; set; }
	}
}
