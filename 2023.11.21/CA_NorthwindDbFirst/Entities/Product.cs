using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindDbFirst.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //Mapping
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        //todo override yapınca hata veriyor.
    }
}
