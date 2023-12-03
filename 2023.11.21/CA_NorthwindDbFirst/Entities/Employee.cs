using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindDbFirst.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }

        //Mapping
        public List<Order> Orders { get; set; }
    }
}
