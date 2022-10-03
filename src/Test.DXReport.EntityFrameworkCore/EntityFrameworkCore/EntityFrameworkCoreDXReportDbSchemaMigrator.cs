using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Module1.EntityFrameworkCore;
using Test.DXReport.Data;
using Volo.Abp.DependencyInjection;

namespace Test.DXReport.EntityFrameworkCore;

public class EntityFrameworkCoreDXReportDbSchemaMigrator
    : IDXReportDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDXReportDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DXReportDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DXReportDbContext>()
            .Database
            .MigrateAsync();

        await _serviceProvider
            .GetRequiredService<Module1DbContext>()
            .Database
            .MigrateAsync();
    }
}
