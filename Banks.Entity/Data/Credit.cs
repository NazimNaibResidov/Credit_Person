using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Banks.Entity.Data
{
   public class Credit
    {
        public Credit()
        {
            StartDate = DateTime.Now;
        }
       
        public int Id { get; set; }
        public decimal Amount { get; set; }
        [UIHint("datetime")]
        public DateTime StartDate { get; set; }
      
        [UIHint("datetime")]
        public DateTime EndDate { get; set; }
        public ICollection<Person> People { get; set; }

    }
}
