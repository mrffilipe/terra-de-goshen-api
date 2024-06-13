using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class ColorMapping : IEntityMapping<ColorRef>
    {
        public override void Configure(EntityTypeBuilder<ColorRef> builder)
        {
            base.Configure(builder);

            builder.ToTable("colors");

            builder.ComplexProperty(e => e.Details).Property(e => e.Value)
                .HasColumnName("value")
                .IsRequired();

            builder.Property(x => x.ImageId)
                .HasColumnName("image_id")
                .IsRequired(false);

            //builder.HasData(
            //    new ColorRef(new ColorVO("Black")),
            //    new ColorRef(new ColorVO("White")),
            //    new ColorRef(new ColorVO("Red")),
            //    new ColorRef(new ColorVO("Green")),
            //    new ColorRef(new ColorVO("Blue"))
            //    );
        }
    }
}