using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InvoiceApp.Configuration;

namespace InvoiceApp.Web.Host.Startup
{
    [DependsOn(
       typeof(InvoiceAppWebCoreModule))]
    public class InvoiceAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public InvoiceAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InvoiceAppWebHostModule).GetAssembly());
        }
    }
}
