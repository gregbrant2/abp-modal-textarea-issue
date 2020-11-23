using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abpForm.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class abpFormMigrationsDbContextFactory : IDesignTimeDbContextFactory<abpFormMigrationsDbContext>
    {
        public abpFormMigrationsDbContext CreateDbContext(string[] args)
        {
            abpFormEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<abpFormMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new abpFormMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../abpForm.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
