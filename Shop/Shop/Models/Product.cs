﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price{ get; set; }
        public int id { get; set; }

    }
}