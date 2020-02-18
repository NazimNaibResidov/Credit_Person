using Banks.Data.Abstrac;

using Banks.Entity.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Banks.Data.Unit
{
    using Concreate;
    public class UnitOfWork : IUnitOfWork
    {
        //disposed default deyeri
        private bool disposed = false;
        private IPeopleResptory _person;
       
        private ICreditResptory _credit;
        private BankDbContext context;
        public UnitOfWork(BankDbContext _bankDbContext)
        {
            
            context = _bankDbContext?? throw new ArgumentNullException("this is not true connection string ");
        }
        public IPeopleResptory peopleResptory {
            get
            {
                return _person ?? (_person = new PersonResptory(context));
            }
        }
        public ICreditResptory creditResptory { get {
                return _credit = _credit ?? (new CreditResptory(context));
            } }
       
        public void Dispose()
        {
             Dispose(true);
            GC.SuppressFinalize(this);
            
        }
        public int SaveChaced()
        {
           
            return context.SaveChanges();
        }
       // dispose patterinin over olumus formas
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                context.Dispose();

            }

            disposed = true;
        }
    }
}
