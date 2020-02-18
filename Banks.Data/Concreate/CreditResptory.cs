using Banks.Data.Abstrac;
using Banks.Data.Core;
using Banks.Entity.Data;

namespace Banks.Data.Concreate
{
    public class CreditResptory:BaseResptory<Credit>,ICreditResptory
    {
        public CreditResptory(BankDbContext context) : base(context)
        {

        }
    }
}
