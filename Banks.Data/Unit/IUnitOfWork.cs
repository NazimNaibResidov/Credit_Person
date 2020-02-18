using Banks.Data.Abstrac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banks.Data.Unit
{
   public interface IUnitOfWork:IDisposable
    {
         IPeopleResptory peopleResptory { get; }
         ICreditResptory creditResptory { get; }
        
         int SaveChaced();
    }
}
