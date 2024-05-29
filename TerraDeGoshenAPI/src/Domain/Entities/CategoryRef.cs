namespace TerraDeGoshenAPI.src.Domain
{
    public class CategoryRef : IEntity
    {
        public CategoryVO Details { get; private set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        protected CategoryRef()
        {
        }

        public CategoryRef(CategoryVO details)
        {
            Details = details;
        }
    }
}