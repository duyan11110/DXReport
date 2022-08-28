using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Module1.EntityFrameworkCore;

[ConnectionStringName(Module1DbProperties.ConnectionStringName)]
public interface IModule1DbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
