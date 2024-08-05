namespace TerraDeGoshenAPI.src.Domain
{
    public class SizeRef : IEntity
    {
        public SizeVO Details { get; private set; } = new SizeVO();
        public IList<Product> Products { get; private set; } = [];

        public SizeRef()
        { }

        public SizeRef(Guid id)
        {
            Id = id;
        }

        public SizeRef(SizeVO details)
        {
            Details = details;
        }
    }
}