using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Invoice
{
    [AutoMapFrom(typeof(Invoice))]
    public class InvoiceDto : EntityDto<int>
    {
        public string InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
