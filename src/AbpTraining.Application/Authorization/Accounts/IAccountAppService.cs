using System.Threading.Tasks;
using Abp.Application.Services;
using AbpTraining.Authorization.Accounts.Dto;

namespace AbpTraining.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
