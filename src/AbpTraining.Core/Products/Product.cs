using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AbpTraining.Products
{
    //可以显示指定表名，不指定默认是实体名+s
    [Table("Product")]
    public class Product : FullAuditedEntity<long>
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
