using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpTraining.EntityFrameworkCore
{
    public static class AbpTrainingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpTrainingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpTrainingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
