using Module1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Module1;

public abstract class Module1Controller : AbpControllerBase
{
    protected Module1Controller()
    {
        LocalizationResource = typeof(Module1Resource);
    }
}
