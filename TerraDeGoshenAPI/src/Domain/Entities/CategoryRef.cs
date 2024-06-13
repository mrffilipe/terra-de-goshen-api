namespace TerraDeGoshenAPI.src.Domain
{
    public class CategoryRef : IEntity
    {
        public CategoryVO Details { get; } = new CategoryVO();
        public Product Product { get; } = new Product();

        public CategoryRef()
        { }

        public CategoryRef(CategoryVO details)
        {
            Details = details;
        }
    }
}