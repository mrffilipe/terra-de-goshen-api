namespace TerraDeGoshenAPI.src.Domain
{
    public class ImageRef : IEntity
    {
        public ImageVO Details { get; } = new ImageVO();
        public Guid ProductId { get; } = Guid.Empty;
        public Product Product { get; } = new Product();

        public ImageRef()
        { }

        public ImageRef(ImageVO details)
        {
            Details = details;
        }
    }
}