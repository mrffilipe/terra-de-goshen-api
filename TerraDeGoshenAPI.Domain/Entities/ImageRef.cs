namespace TerraDeGoshenAPI.Domain;

public class ImageRef : IEntity
{
    public ImageVO Image { get; private set; }

    public ImageRef(ImageVO image)
    {
        Image = image;
    }
}