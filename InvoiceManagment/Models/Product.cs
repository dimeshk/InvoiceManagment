using System;

namespace InvoiceManagment.Models
{
    public class Product
    { 
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Decimal PurchasePrice { get; set; }
        public Decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
    }
}