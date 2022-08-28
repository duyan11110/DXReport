using Volo.Abp.Modularity;

namespace Module1;

[DependsOn(
    typeof(Module1ApplicationModule),
    typeof(Module1DomainTestModule)
    )]
public class Module1ApplicationTestModule : AbpModule
{

}
