using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test.DXReport.Web.Pages.Reporting
{
    public class ViewerModel : PageModel
    {
        //[BindProperty(Name = "docViewModel", SupportsGet = true)]
        //public WebDocumentViewerModel DocViewModel { get; set; }

        [BindProperty(Name = "report", SupportsGet = true)]
        public XtraReport Report { get; set; }
        public void OnGet(XtraReport report)
        {
            Report = report;
        }
    }
}
