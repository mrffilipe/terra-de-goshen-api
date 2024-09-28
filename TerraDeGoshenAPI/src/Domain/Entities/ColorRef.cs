namespace TerraDeGoshenAPI.src.Domain
{
    public class ColorRef : BaseEntity
    {
        public ColorVO Details { get; private set; }
        public Guid? ImageId { get; private set; }
        public IList<Product> Products { get; private set; } = [];

        protected ColorRef() { }

        public ColorRef(ColorVO details, Guid? imageId)
        {
            Details = details ?? throw new ArgumentNullException(nameof(details), "Os detalhes da cor não podem ser nulos.");
            ImageId = imageId ?? throw new ArgumentNullException(nameof(imageId), "O ID da imagem não pode ser nulo.");
        }
    }
}