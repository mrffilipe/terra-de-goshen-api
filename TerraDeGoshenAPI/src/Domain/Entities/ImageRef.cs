namespace TerraDeGoshenAPI.src.Domain
{
    public class ImageRef : IEntity
    {
        public ImageVO Details { get; private set; } = new ImageVO();
        public Guid ProductId { get; private set; } = Guid.Empty;
        public Product Product { get; private set; } = null!;

        public ImageRef()
        { }

        public ImageRef(Guid id)
        {
            Id = id;
        }

        public ImageRef(ImageVO details)
        {
            Details = details;
        }
    }
}