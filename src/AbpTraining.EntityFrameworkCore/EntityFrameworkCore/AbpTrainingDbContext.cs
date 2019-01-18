using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpTraining.Authorization.Roles;
using AbpTraining.Authorization.Users;
using AbpTraining.MultiTenancy;
using AbpTraining.Products;

namespace AbpTraining.EntityFrameworkCore
{
    public class AbpTrainingDbContext : AbpZeroDbContext<Tenant, Role, User, AbpTrainingDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Product> Products { get; set; }   //实体对象集合

        public AbpTrainingDbContext(DbContextOptions<AbpTrainingDbContext> options)
            : base(options)
        {
        }
    }
}
