namespace TerraDeGoshenAPI.src.Domain
{
    public class SizeRef : IEntity
    {
        public SizeVO Details { get; private set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        protected SizeRef()
        {
        }

        public SizeRef(SizeVO details)
        {
            Id = Guid.NewGuid();
            Details = details;
        }
    }
}