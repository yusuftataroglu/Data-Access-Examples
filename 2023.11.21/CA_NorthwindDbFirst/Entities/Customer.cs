﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindDbFirst.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }

        //Mapping
        public List<Order> Orders { get; set; }
    }
}
