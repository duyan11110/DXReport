using Microsoft.EntityFrameworkCore;
using Module1.RemittanceTransactions;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Module1.EntityFrameworkCore;

[ConnectionStringName(Module1DbProperties.ConnectionStringName)]
public class Module1DbContext : AbpDbContext<Module1DbContext>, IModule1DbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<RemittanceTransaction> RemittanceTransactions { get; set; }

    public Module1DbContext(DbContextOptions<Module1DbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureModule1();
    }
}
