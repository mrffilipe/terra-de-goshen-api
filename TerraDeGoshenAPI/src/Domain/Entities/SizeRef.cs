namespace TerraDeGoshenAPI.src.Domain
{
    public class SizeRef : IEntity
    {
        public SizeVO Details { get; private set; }

        public SizeRef(SizeVO details)
        {
            Id = Guid.NewGuid();
            Details = details;
        }
    }
}