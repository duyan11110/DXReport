using Test.DXReport.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Test.DXReport;

[DependsOn(
    typeof(DXReportEntityFrameworkCoreTestModule)
    )]
public class DXReportDomainTestModule : AbpModule
{

}
