using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTraining.Configuration;

namespace AbpTraining.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpTrainingWebCoreModule))]
    public class AbpTrainingWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpTrainingWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpTrainingWebHostModule).GetAssembly());
        }
    }
}
