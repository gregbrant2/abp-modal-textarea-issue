using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abpForm.Data
{
    /* This is used if database provider does't define
     * IabpFormDbSchemaMigrator implementation.
     */
    public class NullabpFormDbSchemaMigrator : IabpFormDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}