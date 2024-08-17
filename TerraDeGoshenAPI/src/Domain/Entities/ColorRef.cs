namespace TerraDeGoshenAPI.src.Domain
{
    public class ColorRef : BaseEntity
    {
        public ColorVO Details { get; private set; }
        public Guid? ImageId { get; private set; }
        public IList<Product> Products { get; private set; } = [];

        public ColorRef(ColorVO details, Guid? imageId)
        {
            Details = details ?? throw new ArgumentNullException(nameof(details));
            ImageId = imageId ?? throw new ArgumentNullException(nameof(imageId));
        }
    }
}