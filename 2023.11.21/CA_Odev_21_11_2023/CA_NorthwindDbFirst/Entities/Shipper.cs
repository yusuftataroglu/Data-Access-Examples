﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindDbFirst.Entities
{
    public class Shipper
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string? PhoneNumber { get; set; }

        //Mapping
        public List<Order> Orders { get; set; }
    }
}
