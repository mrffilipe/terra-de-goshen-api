namespace TerraDeGoshenAPI.src.Domain
{
    public class ImageRef : IEntity
    {
        public ImageVO Details { get; private set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        protected ImageRef()
        {
        }

        public ImageRef(ImageVO details)
        {
            Details = details;
        }
    }
}