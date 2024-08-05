namespace TerraDeGoshenAPI.src.Domain
{
    public class CategoryRef : IEntity
    {
        public CategoryVO Details { get; private set; } = new CategoryVO();
        public IList<Product> Product { get; private set; } = [];

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