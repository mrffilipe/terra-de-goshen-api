namespace TerraDeGoshenAPI.Domain;

public class ColorRef : IEntity
{
    public ColorVO Color { get; private set; }
    public Guid? ImageId { get; private set; } = null;

    public ColorRef(ColorVO color)
    {
        Id = Guid.NewGuid();
        Color = color;
    }

    public ColorRef(ColorVO color, Guid? imageId) : this(color)
    {
        ImageId = imageId;
    }
}