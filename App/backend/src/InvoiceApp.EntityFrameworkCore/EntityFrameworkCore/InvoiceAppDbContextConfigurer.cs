using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.EntityFrameworkCore
{
    public static class InvoiceAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InvoiceAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<InvoiceAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
