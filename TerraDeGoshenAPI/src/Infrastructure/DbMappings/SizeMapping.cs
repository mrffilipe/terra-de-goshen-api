using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class SizeMapping : IEntityMapping<SizeRef>
    {
        public override void Configure(EntityTypeBuilder<SizeRef> builder)
        {
            base.Configure(builder);

            builder.ComplexProperty(e => e.Details).Property(e => e.Value)
                .HasColumnName("value")
                .IsRequired();

            builder.Property(x => x.ProductId)
                .HasColumnName("product_id")
                .IsRequired();
        }
    }
}