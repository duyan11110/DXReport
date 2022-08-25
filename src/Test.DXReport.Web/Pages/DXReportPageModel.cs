using Test.DXReport.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Test.DXReport.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class DXReportPageModel : AbpPageModel
{
    protected DXReportPageModel()
    {
        LocalizationResourceType = typeof(DXReportResource);
    }
}
