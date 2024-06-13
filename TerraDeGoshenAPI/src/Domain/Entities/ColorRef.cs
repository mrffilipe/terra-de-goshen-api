namespace TerraDeGoshenAPI.src.Domain
{
    public class ColorRef : IEntity
    {
        public ColorVO Details { get; } = new ColorVO();
        public Guid? ImageId { get; } = Guid.Empty;
        public IList<Product> Products { get; } = [];

        public ColorRef()
        { }

        public ColorRef(Guid id)
        {
            Id = id;
        }

        public ColorRef(ColorVO details)
        {
            Details = details;
        }

        public ColorRef(ColorVO color, Guid? imageId) : this(color)
        {
            ImageId = imageId;
        }
    }
}