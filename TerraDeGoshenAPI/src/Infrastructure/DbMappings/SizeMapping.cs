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

            builder.ToTable("sizes");

            builder.ComplexProperty(e => e.Details).Property(e => e.Value)
                .HasColumnName("value")
                .IsRequired();

            //builder.HasData(
            //    new SizeRef(new SizeVO("P")),
            //    new SizeRef(new SizeVO("M")),
            //    new SizeRef(new SizeVO("G")),
            //    new SizeRef(new SizeVO("GG")),
            //    new SizeRef(new SizeVO("XG")),
            //    new SizeRef(new SizeVO("XXG"))
            //    );
        }
    }
}