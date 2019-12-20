using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Invoice
{
    public class Invoice : Entity<int>
    {
        public string InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateAdded { get; set; }
    }

    public class InvoiceLineItem : Entity<int>
    { 
        public string InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal Qty { get; set; }
        public int Amount { get; set; }
    }
}
