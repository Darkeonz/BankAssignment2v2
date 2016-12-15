using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment2.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Account account { get; set; }
        public Customer()
        {

        }
    }
}
