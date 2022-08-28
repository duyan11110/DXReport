using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Module1;

[DependsOn(
    typeof(Module1DomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class Module1ApplicationContractsModule : AbpModule
{

}
