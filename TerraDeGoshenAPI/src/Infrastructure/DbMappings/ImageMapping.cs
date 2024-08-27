using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ImageMapping : EntityMapping<ImageRef>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<ImageRef> builder)
        {
            base.Configure(builder);

            builder.ToTable("images");

            builder.ComplexProperty(e => e.Details).Property(e => e.Url)
                .HasColumnName("url")
                .IsRequired();

            builder.ComplexProperty(e => e.Details).Property(e => e.IsCover)
                .HasColumnName("is_cover")
                .IsRequired(false);

            builder.Property(x => x.ProductId)
                .HasColumnName("product_id")
                .IsRequired();
        }
    }
}