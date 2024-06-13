using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ProductMapping : IEntityMapping<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.ToTable("products");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnName("price")
                .IsRequired();

            builder.Property(x => x.BackgroundText)
                .HasColumnName("background_text")
                .IsRequired();

            builder.Property(x => x.QuantityInStock)
                .HasColumnName("quantity_in_stock")
                .IsRequired();

            builder.Property(x => x.CategoryId)
                .HasColumnName("category_id")
                .IsRequired();

            builder.HasMany(e => e.Images)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();

            builder.HasMany(e => e.Colors)
                .WithMany(e => e.Products);

            builder.HasMany(e => e.Sizes)
                .WithMany(e => e.Products);

            builder.HasOne(e => e.Category)
                .WithMany(e => e.Product)
                .HasForeignKey(e => e.CategoryId)
                .IsRequired();
        }
    }
}