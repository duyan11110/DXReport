//using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
//using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Mvc;
using Module1.Web.Reports;
using System.Threading.Tasks;

namespace Module1.Web.Pages.Module1;

public class IndexModel : Module1PageModel
{
    public void OnGet()
    {
        //var modelGenerator = new WebDocumentViewerClientSideModelGenerator(HttpContext.RequestServices);
        //var model = await modelGenerator.GetModelAsync("Module1Report1", WebDocumentViewerController.DefaultUri);
        ////Module1Report1 report = new Module1Report1();
        ////ViewData["Report"] = report;
        //return RedirectToPage("/Reporting/Viewer", new {docViewModel = model });
    }
}
