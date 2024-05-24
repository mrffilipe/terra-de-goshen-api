namespace TerraDeGoshenAPI.Domain;

public class CategoryRef : IEntity
{
    public CategoryVO Details { get; private set; }

    public CategoryRef(CategoryVO details)
    {
        Details = details;
    }
}