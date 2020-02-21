using Banks.Entity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Banks.ApiUI.Core.Extenison
{
    public static class DbContextExtension
    {
        public static void Connection(this IServiceCollection services,IConfiguration Configuration)
        {
            services.AddDbContext<BankDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Bank"), x => x.MigrationsAssembly("Banks.ApiUI")));
        }
    }
}
