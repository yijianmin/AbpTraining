using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbpTraining.Products.Dto
{
    public class GetProductByNameInput
    {
        [Required]     //[Required] -input对象中有此特性，ABP会自动对request的这个字段做必填验证
        public string Name { get; set; }
    }
}
