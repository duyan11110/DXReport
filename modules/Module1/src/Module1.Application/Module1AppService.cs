using Module1.Localization;
using Volo.Abp.Application.Services;

namespace Module1;

public abstract class Module1AppService : ApplicationService
{
    protected Module1AppService()
    {
        LocalizationResource = typeof(Module1Resource);
        ObjectMapperContext = typeof(Module1ApplicationModule);
    }
}
