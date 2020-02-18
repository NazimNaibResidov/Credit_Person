using Banks.Data.Abstrac;
using Banks.Data.Concreate;
using Banks.Data.Unit;
using Microsoft.Extensions.DependencyInjection;

namespace Banks.ApiUI.Core.Extenison
{
    
    public static class TransientExtesion
    {
        public static void LoadServic(this IServiceCollection services)
        {

services.AddTransient<IPeopleResptory, PersonResptory>();
services.AddTransient<ICreditResptory, CreditResptory>();
services.AddTransient<IUnitOfWork,UnitOfWork>();
        }
    }
}
