using Microsoft.EntityFrameworkCore;
using Module1.RemittanceTransactions;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Module1.EntityFrameworkCore;

public static class Module1DbContextModelCreatingExtensions
{
    public static void ConfigureModule1(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<RemittanceTransaction>(entity =>
        {
            entity.ToTable("RemittanceTransaction", Module1DbProperties.DbSchema);
            entity.ConfigureByConvention();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.AcknowledgedDate).HasColumnType("datetime");

            entity.Property(e => e.AmendAckedDate).HasColumnType("datetime");

            entity.Property(e => e.AmendedDate).HasColumnType("datetime");

            entity.Property(e => e.ApplNo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BankCharges)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BeneACCNo)
                .HasMaxLength(34)
                .IsUnicode(false);

            entity.Property(e => e.BeneAddress).HasMaxLength(70);

            entity.Property(e => e.BeneBankAddress).HasMaxLength(70);

            entity.Property(e => e.BeneBankName).HasMaxLength(70);

            entity.Property(e => e.BeneName).HasMaxLength(70);

            entity.Property(e => e.CBADefferedAmount).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.CBADefferedCCY)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.CBAEvidenceAmount).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.CBAEvidenceCCY)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.CBAPart).HasMaxLength(100);

            entity.Property(e => e.CLNo)
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.Property(e => e.ChargeAccount)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConfirmedDate).HasColumnType("datetime");

            entity.Property(e => e.ContractSpread).HasColumnType("decimal(9, 6)");

            entity.Property(e => e.CustomerName).HasMaxLength(250);

            entity.Property(e => e.CustomerRefNo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Customer_Code)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DebitACCurrency1)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.DebitACCurrency2)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.DebitACNo1)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DebitACNo2)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeletedDate).HasColumnType("datetime");

            entity.Property(e => e.DetailsOfPayment).HasMaxLength(140);

            entity.Property(e => e.EquivRMTAmount).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.EquivRMTCCY)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.EvidenceCheckByCBA)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ExportedDate).HasColumnType("datetime");

            entity.Property(e => e.ExportedFileName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.FixRMTAmount).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.GCMSRefNo)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.GOTransNo)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.GroupReferenceNo)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.GroupedDate).HasColumnType("datetime");

            entity.Property(e => e.InputtedDate).HasColumnType("datetime");

            entity.Property(e => e.IntPaymentDate).HasColumnType("datetime");

            entity.Property(e => e.InterestAmt).HasColumnType("decimal(20, 3)");

            entity.Property(e => e.InterestCcy).HasMaxLength(4);

            entity.Property(e => e.InterestRateFinalRate).HasColumnType("decimal(9, 6)");

            entity.Property(e => e.MessageToOP).HasMaxLength(200);

            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.Property(e => e.ODAmount).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.ODEquivAmount).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.ODOutstanding).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.ODCCY)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ODDate).HasColumnType("datetime");

            entity.Property(e => e.ODEquivCCY)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ODFinalDueDate).HasColumnType("datetime");

            entity.Property(e => e.ODRefNo)
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.Property(e => e.ODTRCost).HasColumnType("decimal(9, 6)");

            entity.Property(e => e.ODValueDate).HasColumnType("datetime");

            entity.Property(e => e.OP1DefferedAmount).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.OP1DefferedCCY)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.OtherInstruction).HasMaxLength(200);

            entity.Property(e => e.POIssueingDate).HasColumnType("datetime");

            entity.Property(e => e.POValueDate).HasColumnType("datetime");

            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrincipalRepayDate).HasColumnType("datetime");

            entity.Property(e => e.PrintedDate).HasColumnType("datetime");

            entity.Property(e => e.RMTAmount).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.RMTAmount_AdjustByCBA).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.RMTCCY)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.RMTValueDate).HasColumnType("datetime");

            entity.Property(e => e.RateFixingDate).HasColumnType("datetime");

            entity.Property(e => e.ReceiptDept)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.ReceivingDate).HasColumnType("datetime");

            entity.Property(e => e.ReceptionNo)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.RegisterDate).HasColumnType("datetime");

            entity.Property(e => e.RejectedDate).HasColumnType("datetime");

            entity.Property(e => e.ReturnedDate).HasColumnType("datetime");

            entity.Property(e => e.SendAmendToOPDate).HasColumnType("datetime");

            entity.Property(e => e.SettlementDoc)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TRPart).HasMaxLength(100);

            entity.Property(e => e.TaxPaymentMethod)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.TempoAvailBalance).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.TempoOutstanding).HasColumnType("decimal(25, 2)");

            entity.Property(e => e.TerminatedDate).HasColumnType("datetime");

            entity.Property(e => e.TransactionType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });
    }
}
