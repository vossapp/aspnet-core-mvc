using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.Voss.Authorization.Roles;
using Abp.Voss.Authorization.Users;
using Abp.Voss.MultiTenancy;

namespace Abp.Voss.EntityFrameworkCore
{
    public class VossDbContext : AbpZeroDbContext<Tenant, Role, User, VossDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public VossDbContext(DbContextOptions<VossDbContext> options)
            : base(options)
        {
        }
    }
}
