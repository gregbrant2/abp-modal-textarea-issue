using Volo.Abp.Modularity;

namespace abpForm
{
    [DependsOn(
        typeof(abpFormApplicationModule),
        typeof(abpFormDomainTestModule)
        )]
    public class abpFormApplicationTestModule : AbpModule
    {

    }
}