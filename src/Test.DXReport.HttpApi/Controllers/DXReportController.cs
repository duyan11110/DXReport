using Test.DXReport.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Test.DXReport.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DXReportController : AbpControllerBase
{
    protected DXReportController()
    {
        LocalizationResource = typeof(DXReportResource);
    }
}
