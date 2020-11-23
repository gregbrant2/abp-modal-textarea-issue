using abpForm.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abpForm
{
    [DependsOn(
        typeof(abpFormEntityFrameworkCoreTestModule)
        )]
    public class abpFormDomainTestModule : AbpModule
    {

    }
}