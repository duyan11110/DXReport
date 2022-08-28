using Module1.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Module1;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(Module1EntityFrameworkCoreTestModule)
    )]
public class Module1DomainTestModule : AbpModule
{

}
