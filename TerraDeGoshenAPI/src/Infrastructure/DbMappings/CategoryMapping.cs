using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CategoryMapping : IEntityMapping<CategoryRef>
    {
        public override void Configure(EntityTypeBuilder<CategoryRef> builder)
        {
            base.Configure(builder);

            builder.ComplexProperty(e => e.Details).Property(e => e.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.ProductId)
                .HasColumnName("product_id")
                .IsRequired();
        }
    }
}