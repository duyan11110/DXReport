using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Test.DXReport;

public class DXReportWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<DXReportWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
