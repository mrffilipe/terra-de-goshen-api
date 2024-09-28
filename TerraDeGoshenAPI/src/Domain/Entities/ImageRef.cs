namespace TerraDeGoshenAPI.src.Domain
{
    public class ImageRef : BaseEntity
    {
        public ImageVO Details { get; private set; }
        public Guid ProductId { get; private set; }
        public Product Product { get; private set; } = null!;

        protected ImageRef() { }

        public ImageRef(ImageVO details)
        {
            Details = details ?? throw new ArgumentNullException(nameof(details), "Os detalhes da imagem não podem ser nulos.");
        }
    }
}