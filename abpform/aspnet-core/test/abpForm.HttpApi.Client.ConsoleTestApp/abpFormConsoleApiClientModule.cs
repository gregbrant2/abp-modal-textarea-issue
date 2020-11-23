using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace abpForm.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(abpFormHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class abpFormConsoleApiClientModule : AbpModule
    {
        
    }
}
