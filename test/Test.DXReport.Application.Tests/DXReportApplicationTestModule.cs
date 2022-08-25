using Volo.Abp.Modularity;

namespace Test.DXReport;

[DependsOn(
    typeof(DXReportApplicationModule),
    typeof(DXReportDomainTestModule)
    )]
public class DXReportApplicationTestModule : AbpModule
{

}
