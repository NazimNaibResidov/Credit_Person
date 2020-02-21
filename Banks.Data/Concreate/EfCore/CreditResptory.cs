using Banks.Data.Abstrac;
using Banks.Data.Core;
using Banks.Entity.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banks.Data.Concreate.EfCore
{
    public class CreditResptory : BaseResptory<Credit>, ICreditResptory
    {
        public CreditResptory(BankDbContext context) : base(context)
        {

        }
    }
}
