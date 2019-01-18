using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpTraining.Controllers
{
    public abstract class AbpTrainingControllerBase: AbpController
    {
        protected AbpTrainingControllerBase()
        {
            LocalizationSourceName = AbpTrainingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
