using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTraining.Authorization;

namespace AbpTraining
{
    [DependsOn(
        typeof(AbpTrainingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpTrainingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpTrainingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpTrainingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
