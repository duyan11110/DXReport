using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Module1;

[DependsOn(
    typeof(Module1ApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class Module1HttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(Module1ApplicationContractsModule).Assembly,
            Module1RemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<Module1HttpApiClientModule>();
        });

    }
}
