using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpTraining.MultiTenancy.Dto;

namespace AbpTraining.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

