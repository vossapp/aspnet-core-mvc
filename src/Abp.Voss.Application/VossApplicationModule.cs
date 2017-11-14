using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Voss.Authorization;

namespace Abp.Voss
{
    [DependsOn(
        typeof(VossCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VossApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VossAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VossApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
