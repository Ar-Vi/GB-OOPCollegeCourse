﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBConsoleProject
{
    class Item
    {

        private string dec;
        private double price;

        public Item(string dec, double price)
        {
            this.dec = dec;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Dec : {dec} , Price :  {price}";
        }
    }
}
