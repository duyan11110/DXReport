using System;
using System.Collections.Generic;
using System.Text;
using Test.DXReport.Localization;
using Volo.Abp.Application.Services;

namespace Test.DXReport;

/* Inherit your application services from this class.
 */
public abstract class DXReportAppService : ApplicationService
{
    protected DXReportAppService()
    {
        LocalizationResource = typeof(DXReportResource);
    }
}
