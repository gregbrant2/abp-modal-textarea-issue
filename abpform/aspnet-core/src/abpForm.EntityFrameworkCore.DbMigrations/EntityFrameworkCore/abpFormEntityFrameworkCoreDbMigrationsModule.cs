using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace abpForm.EntityFrameworkCore
{
    [DependsOn(
        typeof(abpFormEntityFrameworkCoreModule)
        )]
    public class abpFormEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<abpFormMigrationsDbContext>();
        }
    }
}
