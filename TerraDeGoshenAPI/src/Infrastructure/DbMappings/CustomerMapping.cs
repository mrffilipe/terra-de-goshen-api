using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CustomerMapping : EntityMapping<Customer>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);

            builder.ToTable("customers");

            builder.Property(x => x.FirstName)
                .HasColumnName("first_name")
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasColumnName("last_name")
                .IsRequired();
        }
    }
}