﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok.Vjezba_Trgovina_Dictionary
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Product(string Name, decimal Price, int Quantity) {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }

    }
}
