using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        public IEnumerable<Product> Products { get; set; }
        private IValueCalculator calc;


        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        
        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }

    }
}