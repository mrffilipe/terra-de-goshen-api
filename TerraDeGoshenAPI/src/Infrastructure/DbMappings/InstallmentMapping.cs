using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class InstallmentMapping : EntityMapping<Installment>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Installment> builder)
        {
            base.Configure(builder);

            builder.ToTable("installments");

            builder.ComplexProperty(e => e.Amount).Property(e => e.Amount)
                .HasColumnName("amount")
                .IsRequired();

            builder.Property(x => x.DueDate)
                .HasColumnName("due_date")
                .IsRequired();

            builder.ComplexProperty(e => e.AmountPaid).Property(e => e.Amount)
                .HasColumnName("amount_paid")
                .IsRequired();

            builder.Property(x => x.IsPaid)
                .HasColumnName("is_paid")
                .IsRequired();

            builder.Property(x => x.DebitId)
                .HasColumnName("debit_id")
                .IsRequired();

            builder.HasOne(x => x.Debt)
                .WithMany(x => x.Installments)
                .HasForeignKey(x => x.DebitId)
                .IsRequired();
        }
    }
}