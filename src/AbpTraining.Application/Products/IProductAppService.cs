using Abp.Application.Services;
using AbpTraining.Products.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbpTraining.Products
{
    public interface IProductAppService : IApplicationService  //应用服务接口要继承IApplicationService
    {
        Task<GetProductByNameOutput> GetProductByName(GetProductByNameInput input);
    }
}
