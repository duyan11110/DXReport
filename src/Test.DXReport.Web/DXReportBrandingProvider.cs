using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Test.DXReport.Web;

[Dependency(ReplaceServices = true)]
public class DXReportBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DXReport";
}
