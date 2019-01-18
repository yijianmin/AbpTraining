using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTraining.Products.Dto
{
    [AutoMapFrom(typeof(Product))]  //AutoMapFrom特性指明从哪一个类可以自动映射到当前类，这样就可以不用手动的去做实体之间的转换
    public class ProductDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
