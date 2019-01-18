using System.Threading.Tasks;
using Abp.Application.Services;
using AbpTraining.Sessions.Dto;

namespace AbpTraining.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
