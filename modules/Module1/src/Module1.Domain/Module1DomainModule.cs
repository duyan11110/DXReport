using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Module1;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(Module1DomainSharedModule)
)]
public class Module1DomainModule : AbpModule
{

}
