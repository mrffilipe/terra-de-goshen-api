namespace TerraDeGoshenAPI.src.Domain
{
    public class CategoryRef : BaseEntity
    {
        public CategoryVO Details { get; private set; }
        public IList<Product> Product { get; private set; } = [];

        public CategoryRef(CategoryVO details)
        {
            Details = details ?? throw new ArgumentNullException(nameof(details));
        }
    }
}