using abpForm.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace abpForm.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(abpFormEntityFrameworkCoreDbMigrationsModule),
        typeof(abpFormApplicationContractsModule)
        )]
    public class abpFormDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
