using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class SizeMapping : EntityMapping<SizeRef>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<SizeRef> builder)
        {
            builder.ToTable("sizes");

            builder.ComplexProperty(e => e.Details).Property(e => e.Value)
                .HasColumnName("value")
                .IsRequired();
        }
    }
}