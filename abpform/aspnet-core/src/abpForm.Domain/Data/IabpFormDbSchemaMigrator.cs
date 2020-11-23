using System.Threading.Tasks;

namespace abpForm.Data
{
    public interface IabpFormDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
