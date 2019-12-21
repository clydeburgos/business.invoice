using Abp.Application.Services;
using Abp.Domain.Repositories;
using InvoiceApp.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp.Customers
{
    public class CustomersAppService : CrudAppService<Customer.Customer, CustomerDto>
    {
        public CustomersAppService(IRepository<Customer.Customer, int> repository) : base(repository)
        {
        }
    }
}
