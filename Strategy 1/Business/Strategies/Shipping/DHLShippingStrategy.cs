using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Pattern_First_Look.Business.Strategies.Shipping
{
    class DHLShippingStrategy : IShippingStrategy
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                /// TODO : Implement DHL shipping strategy

                Console.WriteLine("Order is shipped with DHL");
            }
        }
    }
}
