namespace TerraDeGoshenAPI.src.Domain
{
    public class CategoryRef : IEntity
    {
        public CategoryVO Details { get; private set; }

        public CategoryRef(CategoryVO details)
        {
            Details = details;
        }
    }
}