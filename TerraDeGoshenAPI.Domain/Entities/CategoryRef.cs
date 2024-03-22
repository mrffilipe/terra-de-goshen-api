namespace TerraDeGoshenAPI.Domain;

public class CategoryRef : IEntity
{
    public CategoryVO Category { get; private set; }

    public CategoryRef(CategoryVO category)
    {
        Category = category;
    }
}