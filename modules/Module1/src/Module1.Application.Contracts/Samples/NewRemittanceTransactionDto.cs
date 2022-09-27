using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Module1.Samples
{
    public class NewRemittanceTransactionDto : EntityDto<Guid>
    {
        public string RMTCCY { get; set; }
        public string EquivRMTCCY { get; set; }
        public decimal? RMTAmount { get; set; }
        public decimal? EquivRMTAmount { get; set; }
        public string ODCCY { get; set; }
        public string ODEquivCCY { get; set; }
        public decimal? ODAmount { get; set; }
        public decimal? ODEquivAmount { get; set; }
        public bool? Custodian { get; set; } = null;
        public string DebitACNo2 { get; set; }
        public int? LineNumber { get; set; }
    }
}
