using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class TransactionMapping : EntityMapping<Transaction>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("transactions");

            builder.ComplexProperty(e => e.Amount).Property(e => e.Amount)
                .HasColumnName("amount")
                .IsRequired();

            builder.Property(x => x.TransactionType)
                .HasColumnName("type")
                .IsRequired();

            builder.Property(x => x.PaymentMethod)
                .HasColumnName("payment_method")
                .IsRequired();

            builder.Property(x => x.CashRegisterId)
                .HasColumnName("cash_register_id")
                .IsRequired();

            builder.Property(x => x.ProductId)
                .HasColumnName("product_id")
                .IsRequired();

            builder.Property(x => x.CustomerId)
                .HasColumnName("customer_id")
                .IsRequired(false);

            builder.HasOne(x => x.CashRegister)
                .WithMany(x => x.Transactions)
                .IsRequired();

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Transactions)
                .IsRequired(false);

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Transactions)
                .IsRequired(false);
        }
    }
}