using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindDbFirst.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }

        //Mapping
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }

    }
}
