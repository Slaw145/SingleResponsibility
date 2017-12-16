using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    class Order
    {
        public int NumberOrder { get; set; }

        public void AddOrder()
        {
            NumberOrder += 1;
        }

        public string GiveOrder()
        {
            return "Order placed!";
        }
    }

}
