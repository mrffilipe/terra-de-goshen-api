namespace TerraDeGoshenAPI.src.Domain
{
    public class SizeRef : IEntity
    {
        public SizeVO Details { get; } = new SizeVO();
        public IList<Product> Products { get; } = [];

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