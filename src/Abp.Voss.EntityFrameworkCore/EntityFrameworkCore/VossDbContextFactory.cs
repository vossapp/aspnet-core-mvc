using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Abp.Voss.Configuration;
using Abp.Voss.Web;

namespace Abp.Voss.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VossDbContextFactory : IDesignTimeDbContextFactory<VossDbContext>
    {
        public VossDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VossDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VossDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VossConsts.ConnectionStringName));

            return new VossDbContext(builder.Options);
        }
    }
}
