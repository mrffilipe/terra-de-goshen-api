namespace TerraDeGoshenAPI.src.Domain
{
    public class ColorRef : IEntity
    {
        public ColorVO Details { get; private set; }
        public Guid? ImageId { get; private set; } = null;
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        protected ColorRef()
        {
        }

        public ColorRef(ColorVO details)
        {
            Id = Guid.NewGuid();
            Details = details;
        }

        public ColorRef(ColorVO color, Guid? imageId) : this(color)
        {
            ImageId = imageId;
        }
    }
}