using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banks.Entity.Data
{
   public class BankDbContext:DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options):base(options)
        {

        }
     
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
