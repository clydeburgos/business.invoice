using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Invoice
{
    [AutoMapFrom(typeof(InvoiceLineItem))]
    public class InvoiceLineItemDto : EntityDto<int>
    {
        public string InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal Qty { get; set; }
        public int Amount { get; set; }
    }
}
