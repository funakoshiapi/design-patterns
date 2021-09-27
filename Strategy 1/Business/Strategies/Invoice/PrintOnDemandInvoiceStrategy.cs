using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Strategy_Pattern_First_Look.Business.Models;


namespace Strategy_Pattern_First_Look.Business.Strategies.Invoice
{
    class PrintOnDemandInvoiceStrategy : IInvoiceStrategy
    {
        public void Generate(Order order)
        {
            using (var client = new HttpClient())
            {
                var content = JsonConvert.SerializeObject(order);
                client.BaseAddress = new Uri("http//someapi.com");
                client.PostAsync("/print-on-demand", new StringContent(content));
            }
        }
    }
}
