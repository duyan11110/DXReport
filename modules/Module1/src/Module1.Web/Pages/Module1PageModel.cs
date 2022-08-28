using Module1.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Module1.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class Module1PageModel : AbpPageModel
{
    protected Module1PageModel()
    {
        LocalizationResourceType = typeof(Module1Resource);
        ObjectMapperContext = typeof(Module1WebModule);
    }
}
