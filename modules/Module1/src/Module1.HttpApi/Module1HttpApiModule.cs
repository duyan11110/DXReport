using Localization.Resources.AbpUi;
using Module1.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Module1;

[DependsOn(
    typeof(Module1ApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class Module1HttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(Module1HttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<Module1Resource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
