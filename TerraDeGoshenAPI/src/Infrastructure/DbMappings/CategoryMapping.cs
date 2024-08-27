using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CategoryMapping : EntityMapping<CategoryRef>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<CategoryRef> builder)
        {
            base.Configure(builder);

            builder.ToTable("categories");

            builder.ComplexProperty(e => e.Details).Property(e => e.Name)
                .HasColumnName("name")
                .IsRequired();
        }
    }
}