using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Pattern_First_Look.Business.Strategies.Invoice
{
    public class EmailInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using (SmtpClient client = new SmtpClient("smtp.sendgrid.net", 587))
            {
                NetworkCredential credentials = new NetworkCredential("fsilva", " ");
                client.Credentials = credentials;

                MailMessage mail = new MailMessage("fsilva@avfuel.com", "fsilva@avfuel.com")
                {
                    Subject = "We've created an invoice for your order",
                    Body = GenerateTextInvoice(order)
                };

                client.Send(mail);
            }
        }
    }
}
