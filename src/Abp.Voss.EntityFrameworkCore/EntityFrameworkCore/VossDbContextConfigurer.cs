using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Abp.Voss.EntityFrameworkCore
{
    public static class VossDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VossDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VossDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
