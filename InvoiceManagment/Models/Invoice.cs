using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManagment.Models
{
    public class Invoice
    {
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int TotalUnits { get; set; }
        public Decimal TotalPrice { get; set; }
        public Decimal Discount { get; set; }
        public Customer objcu { get; set; }
        public Product objpro { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
    }
}