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
        
        public InvoiceAppDbContext(DbContextOptions<InvoiceAppDbContext> options)
            : base(options)
        {
        }
    }
}
