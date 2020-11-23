using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace abpForm.EntityFrameworkCore
{
    public static class abpFormDbContextModelCreatingExtensions
    {
        public static void ConfigureabpForm(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(abpFormConsts.DbTablePrefix + "YourEntities", abpFormConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}