using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AbpTraining.Products
{
    public class ProductDomainService : DomainService   //领域服务要继承DomainService
    {
        private readonly IRepository<Product, long> _productRepository;

        public ProductDomainService(IRepository<Product, long> productRepository)
        {
            //_productRepository数据仓储直接依赖注入
            _productRepository = productRepository;
        }

        public async Task<Product> GetProductByName(string name)
        {
            //Linq to Sql
            var query = from p in _productRepository.GetAll()
                        where p.Name == name
                        select p;
            var product = await query.FirstOrDefaultAsync();
            if (product == null)
            {
                //返回业务错误消息给客户端
                throw new UserFriendlyException($"商品({name})不存在");
            }
            if (product.Price < 0)
            {
                throw new UserFriendlyException($"商品({name})的价格小于0，请检查");
            }
            return product;
        }
    }
}
