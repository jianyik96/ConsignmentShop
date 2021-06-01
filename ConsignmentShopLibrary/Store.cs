﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<Item>();
        }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }
    }
}
