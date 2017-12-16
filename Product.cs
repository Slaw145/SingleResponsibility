using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    class Product
    {
        public void PriceProduct(double price)
        {
            Console.WriteLine("This product costs: " + price);
        }
    }
}
