using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Test.DXReport.Web.Reports;

namespace Test.DXReport.Web.Pages;

public class IndexModel : DXReportPageModel
{
    public RedirectToPageResult OnGet()
    {
        XtraReport1 report = new XtraReport1();
        //ViewData["Report"] = report;
        return RedirectToPage("/Reporting/Viewer", new { report = report });
        //var modelGenerator = new WebDocumentViewerClientSideModelGenerator(HttpContext.RequestServices);
        //var model = await modelGenerator.GetModelAsync("Report1", WebDocumentViewerController.DefaultUri);
        //Module1Report1 report = new Module1Report1();
        //ViewData["Report"] = report;
        //return RedirectToPage("/Reporting/Viewer", new {id =1, docViewModel = model });
    }
}
