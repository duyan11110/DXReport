using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Module1.Samples;
using System.Collections;
using System.Collections.Generic;

namespace Module1.Web.Pages.Module1.SettlementManagement
{
    public class IndexModel : PageModel
    {
        public IList<RemittanceTransactionGetListViewDto> RMTList { get; set; }

        public void OnGet()
        {
            this.RMTList = new List<RemittanceTransactionGetListViewDto>();
            RemittanceTransactionGetListViewDto remittanceTransactionGetListViewDto = new RemittanceTransactionGetListViewDto();
            remittanceTransactionGetListViewDto.Source = "Manual input";
            this.RMTList.Add(remittanceTransactionGetListViewDto);
        }
    }
}
