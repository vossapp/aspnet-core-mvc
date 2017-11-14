using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Voss.Configuration;
using Abp.Voss.EntityFrameworkCore;
using Abp.Voss.Migrator.DependencyInjection;

namespace Abp.Voss.Migrator
{
    [DependsOn(typeof(VossEntityFrameworkModule))]
    public class VossMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public VossMigratorModule(VossEntityFrameworkModule VossEntityFrameworkModule)
        {
            VossEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(VossMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                VossConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VossMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
