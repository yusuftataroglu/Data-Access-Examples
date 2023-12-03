using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindDbFirst.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }

        //Mapping
        public List<OrderDetail> OrderDetails { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public Shipper Shipper { get; set; }
        public int ShipperId { get; set;
        }

    }
}
