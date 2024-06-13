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

            builder.ToTable("categories");

            builder.ComplexProperty(e => e.Details).Property(e => e.Name)
                .HasColumnName("name")
                .IsRequired();

            //builder.HasData(
            //    new CategoryRef(new CategoryVO("Camisetas")),
            //    new CategoryRef(new CategoryVO("Vestidos")),
            //    new CategoryRef(new CategoryVO("Calças")),
            //    new CategoryRef(new CategoryVO("Calçados"))
            //    );
        }
    }
}