using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abpForm.Data;
using Volo.Abp.DependencyInjection;

namespace abpForm.EntityFrameworkCore
{
    public class EntityFrameworkCoreabpFormDbSchemaMigrator
        : IabpFormDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreabpFormDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the abpFormMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<abpFormMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}