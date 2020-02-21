using Banks.Data.Abstrac;
using Banks.Data.Core;
using Banks.Entity.Data;

namespace Banks.Data.Concreate.EfCore
{
    public class PersonResptory : BaseResptory<Person>, IPeopleResptory
    {
        public PersonResptory(BankDbContext context) : base(context)
        {

        }
    }
}
