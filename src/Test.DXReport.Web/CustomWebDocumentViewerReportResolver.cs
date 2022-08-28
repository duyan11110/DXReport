using DevExpress.XtraReports.Web.WebDocumentViewer;
using DevExpress.XtraReports.UI;
using Test.DXReport.Web.Reports;
using System;
using Module1.Web.Reports;

namespace Test.DXReport.Web;
public class CustomWebDocumentViewerReportResolver : IWebDocumentViewerReportResolver
{
    public CustomWebDocumentViewerReportResolver() { }

    public XtraReport Resolve(string reportUniqueName)
    {
        switch (reportUniqueName)
        {
            case "Report1":
                return new XtraReport1();
            case "Report2":
                return new XtraReport1();
            case "Module1Report1":
                return new Module1Report1();
            default:
                // Try to create a report using the fully qualified type name.
                Type t = Type.GetType(reportUniqueName);
                return typeof(XtraReport).IsAssignableFrom(t) ?
                    (XtraReport)Activator.CreateInstance(t) :
                    null;
        }
    }
}