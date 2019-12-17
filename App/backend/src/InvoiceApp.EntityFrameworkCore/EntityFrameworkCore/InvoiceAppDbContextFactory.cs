using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using InvoiceApp.Configuration;
using InvoiceApp.Web;

namespace InvoiceApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class InvoiceAppDbContextFactory : IDesignTimeDbContextFactory<InvoiceAppDbContext>
    {
        public InvoiceAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<InvoiceAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            InvoiceAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(InvoiceAppConsts.ConnectionStringName));

            return new InvoiceAppDbContext(builder.Options);
        }
    }
}
