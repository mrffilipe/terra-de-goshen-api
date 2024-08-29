using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ProductMapping : EntityMapping<Product>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("products");

            builder.Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("description")
                .IsRequired();

            builder.ComplexProperty(x => x.Price).Property(e => e.Amount)
                .HasColumnName("price")
                .IsRequired();

            builder.ComplexProperty(x => x.CostPrice).Property(e => e.Amount)
                .HasColumnName("cost_price")
                .IsRequired();

            builder.Property(x => x.BackgroundText)
                .HasColumnName("background_text")
                .IsRequired();

            builder.ComplexProperty(x => x.Stock).Property(e => e.Amount)
                .HasColumnName("stock")
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
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId)
                .IsRequired();

            builder.HasMany(e => e.Transactions)
                .WithOne(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();
        }
    }
}