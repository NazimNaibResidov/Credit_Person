using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banks.ApiUI.Models
{
    public class CreditPerson
    {
        public string UserName { get; set; }
        public string SurName { get; set; }
        public string passNum { get; set; }
        public string Email { get; set; }
        public decimal amount { get; set; }
        public DateTime endDate { get; set; }
    }
}
