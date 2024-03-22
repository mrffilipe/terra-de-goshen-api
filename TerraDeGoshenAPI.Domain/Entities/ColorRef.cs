namespace TerraDeGoshenAPI.Domain;

public class ColorRef : IEntity
{
    public ColorVO Color { get; private set; }

    public ColorRef(ColorVO color)
    {
        Color = color;
    }
}