namespace TerraDeGoshenAPI.src.Domain
{
    public class ColorRef : IEntity
    {
        public ColorVO Details { get; private set; } = new ColorVO();
        public Guid? ImageId { get; private set; } = Guid.Empty;
        public IList<Product> Products { get; private set; } = [];

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