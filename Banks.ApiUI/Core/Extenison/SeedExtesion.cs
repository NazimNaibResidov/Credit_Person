using Banks.Entity.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Banks.ApiUI.Core.Extenison
{
    public static class SeedExtesion
    {
        public async static void SeedItems(this IApplicationBuilder app)
        {
         BankDbContext context=   app.ApplicationServices.GetRequiredService<BankDbContext>();
            context.Database.Migrate();
            if (!await context.Credits.AnyAsync())
            {
                context.Credits.AddRange(
                    new Credit { Amount = 1120, EndDate = DateTime.Now.AddDays(100) },
                     new Credit { Amount = 1820, EndDate = DateTime.Now.AddDays(90) },
                      new Credit { Amount = 1920, EndDate = DateTime.Now.AddDays(70) }
                    );
                await context.SaveChangesAsync();
            }
            if (!await context.People.AnyAsync())
            {
                context.People.AddRange(
                  
                      new Person { Name = "Memmed", Email = "hesen@gmail.com", Surname = "Memmedov", passnum = "12995695",CreditId=1 },
                      new Person { Name = "Memmed", Email = "hesen@gmail.com", Surname = "Memmedov", passnum = "12995695", CreditId = 2 },
                      new Person { Name = "Memmed", Email = "hesen@gmail.com", Surname = "Memmedov", passnum = "12995695", CreditId = 3 }
                    );
                await context.SaveChangesAsync();

            }
            
           

         
            
        }
    }
}
