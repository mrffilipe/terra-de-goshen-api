using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class DebtMapping : EntityMapping<Debt>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Debt> builder)
        {
            builder.ToTable("debts");

            builder.ComplexProperty(e => e.TotalAmount).Property(e => e.Amount)
                .HasColumnName("total_amount")
                .IsRequired();

            builder.Property(x => x.DueDate)
                .HasColumnName("due_date")
                .IsRequired();

            builder.Property(x => x.InstallmentCount)
                .HasColumnName("installment_count")
                .IsRequired();

            builder.Property(x => x.PaymentMethod)
                .HasColumnName("payment_method")
                .IsRequired();

            builder.ComplexProperty(e => e.InitialPayment).Property(e => e.Amount)
                .HasColumnName("initial_payment")
                .IsRequired();

            builder.Property(x => x.CustomerId)
                .HasColumnName("customer_id")
                .IsRequired();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Debts)
                .IsRequired();
        }
    }
}