namespace TerraDeGoshenAPI.src.Domain
{
    public class CategoryRef : IEntity
    {
        public CategoryVO Details { get; } = new CategoryVO();
        public IList<Product> Product { get; } = [];

        public CategoryRef()
        { }

        public CategoryRef(Guid id)
        {
            Id = id;
        }

        public CategoryRef(CategoryVO details)
        {
            Details = details;
        }
    }
}