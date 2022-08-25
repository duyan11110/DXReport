using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Test.DXReport.Data;

/* This is used if database provider does't define
 * IDXReportDbSchemaMigrator implementation.
 */
public class NullDXReportDbSchemaMigrator : IDXReportDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
