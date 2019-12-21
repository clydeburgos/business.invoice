using Abp.Application.Services;
using Abp.Domain.Repositories;
using InvoiceApp.Invoice;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Invoices
{
    public class InvoiceLineItemAppService : CrudAppService<Invoice.InvoiceLineItem, InvoiceLineItemDto>
    {
        public InvoiceLineItemAppService(IRepository<InvoiceLineItem, int> repository) : base(repository)
        {
        }
    }
}
