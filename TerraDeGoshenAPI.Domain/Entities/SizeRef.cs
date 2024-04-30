namespace TerraDeGoshenAPI.Domain;

public class SizeRef : IEntity
{
    public SizeVO Size { get; private set; }

    public SizeRef(SizeVO size)
    {
        Id = Guid.NewGuid();
        Size = size;
    }
}