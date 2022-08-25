using System.Threading.Tasks;

namespace Test.DXReport.Data;

public interface IDXReportDbSchemaMigrator
{
    Task MigrateAsync();
}
