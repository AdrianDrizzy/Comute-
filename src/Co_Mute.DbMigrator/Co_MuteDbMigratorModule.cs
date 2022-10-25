using Co_Mute.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Co_Mute.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Co_MuteEntityFrameworkCoreModule),
    typeof(Co_MuteApplicationContractsModule)
    )]
public class Co_MuteDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
