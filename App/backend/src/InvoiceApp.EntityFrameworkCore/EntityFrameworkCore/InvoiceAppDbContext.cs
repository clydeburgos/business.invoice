using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using InvoiceApp.Authorization.Roles;
using InvoiceApp.Authorization.Users;
using InvoiceApp.MultiTenancy;

namespace InvoiceApp.EntityFrameworkCore
{
    public class InvoiceAppDbContext : AbpZeroDbContext<Tenant, Role, User, InvoiceAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Customer.Customer> Customers { get; set; }
        public DbSet<Products.Product> Products { get; set; }
        public DbSet<Invoice.Invoice> Invoices { get; set; }
        public DbSet<Invoice.InvoiceLineItem> InvoiceLineItems { get; set; }
        public InvoiceAppDbContext(DbContextOptions<InvoiceAppDbContext> options)
            : base(options)
        {
        }
    }
}
