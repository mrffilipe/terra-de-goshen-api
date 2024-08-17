namespace TerraDeGoshenAPI.src.Domain
{
    public class SizeRef : BaseEntity
    {
        public SizeVO Details { get; private set; }
        public IList<Product> Products { get; private set; } = [];

        public SizeRef(SizeVO details)
        {
            Details = details ?? throw new ArgumentNullException(nameof(details));
        }
    }
}