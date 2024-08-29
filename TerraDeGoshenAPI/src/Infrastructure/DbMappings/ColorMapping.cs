using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ColorMapping : EntityMapping<ColorRef>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<ColorRef> builder)
        {
            builder.ToTable("colors");

            builder.ComplexProperty(e => e.Details).Property(e => e.Value)
                .HasColumnName("value")
                .IsRequired();

            builder.Property(x => x.ImageId)
                .HasColumnName("image_id")
                .IsRequired(false);
        }
    }
}