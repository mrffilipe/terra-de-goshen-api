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

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnName("price")
                .IsRequired();

            builder.Property(x => x.QuantityInStock)
                .HasColumnName("quantity_in_stock")
                .IsRequired();

            builder.HasMany(e => e.Images)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();

            builder.HasMany(e => e.Colors)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();

            builder.HasMany(e => e.Sizes)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();

            builder.HasOne(e => e.Category)
                .WithOne(e => e.Product)
                .HasForeignKey<CategoryRef>(e => e.ProductId)
                .IsRequired();
        }
    }
}