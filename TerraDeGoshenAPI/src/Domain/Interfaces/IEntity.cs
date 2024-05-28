namespace TerraDeGoshenAPI.src.Domain
{
    public abstract class IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}