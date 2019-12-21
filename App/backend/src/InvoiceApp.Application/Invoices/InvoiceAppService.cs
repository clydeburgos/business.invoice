using Abp.Application.Services;
using Abp.Domain.Repositories;
using InvoiceApp.Invoice;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Invoices
{
    public class InvoiceAppService : CrudAppService<Invoice.Invoice, InvoiceDto>
    {
        public InvoiceAppService(IRepository<Invoice.Invoice, int> repository) : base(repository)
        {
        }
    }
}
