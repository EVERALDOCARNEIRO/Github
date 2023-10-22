using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI
{
	public class Startup
	{
		public IConfiguration Configuration { get; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		var connection = Configuration["MySQLConnection : MySQLConnectionString"];

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			
			services.AddDbContext<MySQLContext>(options => options.
				UseMySql(connection, 
					new MySqlServerVersion(
						new Version(8,0,34))));

			services.AddControllers();
		
		}

	}
}
