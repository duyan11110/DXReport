using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace Module1.RemittanceTransactions
{
    public class RemittanceTransaction : AggregateRoot<Guid>, IMultiTenant
    {
        public Guid? ODConfimationId { get; set; }
        public int? CustomerID { get; set; }
        public string CustomerRefNo { get; set; }   
        public string Source { get; set; }
        public bool? Amendment { get; set; } 
        public Guid? RMTStatusID { get; set; }
        public string RMTCCY { get; set; }
        public string EquivRMTCCY { get; set; }
        public decimal? RMTAmount { get; set; }
        public decimal? EquivRMTAmount { get; set; }
        public DateTime? ODDate { get; set; }
        public DateTime? ODValueDate { get; set; }
        public DateTime? ODFinalDueDate { get; set; }
        public string ODCCY { get; set; }
        public string ODEquivCCY { get; set; }
        public decimal? ODAmount { get; set; }
        public decimal? ODEquivAmount { get; set; }
        public decimal? ODOutstanding { get; set; }
        public string ReceiptDept { get; set; }
        public string SettlementDoc { get; set; }
        public string ReferenceNo { get; set; }
        public string ReceptionNo { get; set; }
        public string GCMSRefNo { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public DateTime? RMTValueDate { get; set; }
        public DateTime? POIssueingDate { get; set; }
        public DateTime? POValueDate { get; set; }
        public string BeneName { get; set; }
        public string BeneAddress { get; set; }
        public string BeneACCNo { get; set; }
        public string BeneBankName { get; set; }
        public string BeneBankAddress { get; set; }
        public string DebitACNo1 { get; set; }  
        public string DebitACCurrency1 { get; set; }
        public string DebitACNo2 { get; set; }
        public string DebitACCurrency2 { get; set; }
        public bool? Custodian { get; set; }
        public string BankCharges { get; set; }
        public string ChargeAccount { get; set; }
        public string DetailsOfPayment { get; set; }
        public string OtherInstruction { get; set; }
        public string EvidenceCheckByCBA { get; set; }
        public string CBAEvidenceCCY { get; set; }
        public decimal? CBAEvidenceAmount { get; set; }
        public string CBADefferedCCY { get; set; }
        public decimal? CBADefferedAmount { get; set; }
        public string OP1DefferedCCY { get; set; }
        public decimal? OP1DefferedAmount { get; set; }
        public bool? FundConfirm { get; set; }
        public bool? SendMT199ToBeneBank { get; set; }
        public bool? ODFX { get; set; }
        public bool? MultipleODFX { get; set; }
        public string TRPart { get; set; }
        public string CBAPart { get; set; }
        public string MessageToOP { get; set; }
        public string ODRefNo { get; set; }
        public string PaymentMethod { get; set; }
        public string TaxPaymentMethod { get; set; }
        public DateTime? RegisterDate { get; set; } //not modifier
        public int? LineNumber { get; set; } //not modifier
        public string TransactionType { get; set; }
        public bool? DebitTotalFlag { get; set; }
        public bool? TaxPayment { get; set; }
        public string ApplNo { get; set; }
        public DateTime? IntPaymentDate { get; set; }
        public int? IntPaymentInterval { get; set; }
        public int? IntPaymentIntervalType { get; set; }
        public int? IntPaymentNoOfDay { get; set; }
        public DateTime? PrincipalRepayDate { get; set; }
        public int? PrincipalRepayInterval { get; set; }
        public int? PrincipalRepayIntervalType { get; set; }
        public int? PrincipalRepayNoOfDay { get; set; }
        public string Remark { get; set; }
        public decimal? ODTRCost { get; set; }
        public DateTime? RateFixingDate { get; set; }
        public decimal? ContractSpread { get; set; }
        public int? CostType { get; set; }
        public decimal? InterestRateFinalRate { get; set; }
        public int? FixFloat { get; set; }
        public string InterestCcy { get; set; }
        public decimal? InterestAmt { get; set; }
        public int? InterestDays { get; set; }
        public string CLNo { get; set; }
        public decimal? TempoOutstanding { get; set; }
        public decimal? TempoAvailBalance { get; set; }
        public bool? IsOverDue { get; set; }
        public int? PrintCount { get; set; }
        public Guid? PrintedBy { get; set; }
        public DateTime? PrintedDate { get; set; }
        public Guid? InputtedBy { get; set; }
        public DateTime? InputtedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? GroupedBy { get; set; }
        public DateTime? GroupedDate { get; set; }
        public Guid? AmendedBy { get; set; }
        public DateTime? AmendedDate { get; set; }
        public Guid? AmendAckedBy { get; set; }
        public DateTime? AmendAckedDate { get; set; }
        public Guid? SendAmendToOPBy { get; set; }
        public DateTime? SendAmendToOPDate { get; set; }
        public Guid? AcknowledgedBy { get; set; }
        public DateTime? AcknowledgedDate { get; set; }
        public Guid? ConfirmedBy { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public Guid? ReturnedBy { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? RejectedBy { get; set; }
        public DateTime? RejectedDate { get; set; }
        public DateTime? ExportedDate { get; set; }
        public string ExportedFileName { get; set; }
        public int? ExportStatus { get; set; }
        public bool? IsPrinted { get; set; }
        public string Customer_Code { get; set; }
        public string CustomerName { get; set; }
        public decimal? FixRMTAmount { get; set; }
        public string GroupReferenceNo { get; set; }
        public string GOTransNo { get; set; }
        public Guid? GOGeneratingSession { get; set; }
        public Guid? GOTransStatusID { get; set; }
        public decimal? RMTAmount_AdjustByCBA { get; set; }
        public Guid? TerminatedBy { get; set; }
        public DateTime? TerminatedDate { get; set; }

        public Guid? TenantId { get; set; }
    }
}
