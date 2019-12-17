using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InvoiceApp.Authorization;

namespace InvoiceApp
{
    [DependsOn(
        typeof(InvoiceAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class InvoiceAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<InvoiceAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(InvoiceAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
