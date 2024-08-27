using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CashRegisterMapping : EntityMapping<CashRegister>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<CashRegister> builder)
        {
            base.Configure(builder);

            builder.ToTable("cash_registers");

            builder.ComplexProperty(e => e.CurrentBalance).Property(e => e.Amount)
                .HasColumnName("current_balance")
                .IsRequired();
        }
    }
}