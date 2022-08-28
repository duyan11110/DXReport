using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Module1;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Module1HttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class Module1ConsoleApiClientModule : AbpModule
{

}
