﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpTraining.Configuration;
using AbpTraining.Web;

namespace AbpTraining.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpTrainingDbContextFactory : IDesignTimeDbContextFactory<AbpTrainingDbContext>
    {
        public AbpTrainingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpTrainingDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpTrainingDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpTrainingConsts.ConnectionStringName));

            return new AbpTrainingDbContext(builder.Options);
        }
    }
}
