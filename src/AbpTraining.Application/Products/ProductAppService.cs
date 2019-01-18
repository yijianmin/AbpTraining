using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AbpTraining.Products.Dto;

namespace AbpTraining.Products
{
    //应用服务实现要继承AbpTrainingAppServiceBase
    public class ProductAppService : AbpTrainingAppServiceBase, IProductAppService
    {
        private readonly ProductDomainService _productDomainService;

        public ProductAppService(ProductDomainService productDomainService)
        {
            _productDomainService = productDomainService;
        }

        public async Task<GetProductByNameOutput> GetProductByName(GetProductByNameInput input)
        {
            //1.将input dto转换为domain obj

            //2.调用domain service
            var item = await _productDomainService.GetProductByName(input.Name);
            //call other domain service

            //3.将domain obj转换为output dto
            var output = ObjectMapper.Map<GetProductByNameOutput>(item);

            return output;
        }
    }
}
