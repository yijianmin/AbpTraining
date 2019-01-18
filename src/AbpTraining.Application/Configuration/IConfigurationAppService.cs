using System.Threading.Tasks;
using AbpTraining.Configuration.Dto;

namespace AbpTraining.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
