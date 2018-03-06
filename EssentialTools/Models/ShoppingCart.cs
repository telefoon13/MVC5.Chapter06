using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        public IEnumerable<Product> Products { get; set; }
        private LinqValueCalculator calc;


        public ShoppingCart(LinqValueCalculator calcParam)
        {
            calc = calcParam;
        }
        
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }

    }
}