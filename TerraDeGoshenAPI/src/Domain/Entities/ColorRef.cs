namespace TerraDeGoshenAPI.src.Domain
{
    public class ColorRef : BaseEntity
    {
        public ColorVO Details { get; private set; }
        public IList<Product> Products { get; private set; } = [];

        protected ColorRef() { }

        public ColorRef(ColorVO details)
        {
            Details = details ?? throw new ArgumentNullException(nameof(details), "Os detalhes da cor não podem ser nulos.");
        }
    }
}