﻿using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Dtos
{
    public class ShoppingDto
    {
        public List<Product> Products { get; set; }
        public string PasswordCustomer { get; set; }
        public DateTime DateTime { get; set; }
        public double PricePaying { get; set; }
        public int Id { get; set; }
    }
}
