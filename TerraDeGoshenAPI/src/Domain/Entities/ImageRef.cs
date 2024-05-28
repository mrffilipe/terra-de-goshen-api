namespace TerraDeGoshenAPI.src.Domain
{
    public class ImageRef : IEntity
    {
        public ImageVO Details { get; private set; }

        public ImageRef(ImageVO details)
        {
            Details = details;
        }
    }
}