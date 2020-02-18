using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banks.Entity.Data
{
   public class Person
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Surname { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        [StringLength(25)]
        public string passnum { get; set; }
        public int CreditId { get; set; }
        public Credit Credit { get; set; }
    }
}
