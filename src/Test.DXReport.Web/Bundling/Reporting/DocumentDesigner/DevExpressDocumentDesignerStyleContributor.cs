using System.Collections.Generic;
using Test.DXReport.Web.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace Test.DXReport.Web.Bundling.Reporting.DocumentDesigner;

[DependsOn(
    typeof(DevExtremeStyleContributor)
)]
public class DevExpressDocumentDesignerStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/libs/devexpress-analytics-core/css/dx-querybuilder.css");
        context.Files.AddIfNotContains("/libs/devexpress-reporting/css/dx-reportdesigner.css");
    }
}