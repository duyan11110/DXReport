using Test.DXReport.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Test.DXReport.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DXReportEntityFrameworkCoreModule),
    typeof(DXReportApplicationContractsModule)
    )]
public class DXReportDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
