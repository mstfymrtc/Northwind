﻿using System.Collections.Generic;
using MY.Northwind.Entity.Concrete;

namespace MY.Northwind.WebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}