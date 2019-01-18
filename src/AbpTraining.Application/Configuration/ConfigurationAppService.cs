using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpTraining.Configuration.Dto;

namespace AbpTraining.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpTrainingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
