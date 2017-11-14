using Abp.MultiTenancy;
using Abp.Voss.Authorization.Users;

namespace Abp.Voss.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
