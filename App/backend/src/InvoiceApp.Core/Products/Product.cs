using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Products
{
    public class Product : Entity<int>
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; } 
    }
}
