﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BozeAspNetFinal.Models {

    public class Product {

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime ShippingDate { get; set; }

        public int? CategoryId { get; set; }


        public virtual Category Category { get; set; }
    }
}