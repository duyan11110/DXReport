//using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
//using DevExpress.XtraReports.Web.WebDocumentViewer;
using Microsoft.AspNetCore.Mvc;
using Module1.Samples;
using Module1.Web.Reports;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Module1.Web.Pages.Module1;

public class IndexModel : Module1PageModel
{
    public IList<NewRemittanceTransactionDto> RMTList { get; set; }
    public void OnGet()
    {
    }
}
