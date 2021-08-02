﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManagment.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        
    }
}