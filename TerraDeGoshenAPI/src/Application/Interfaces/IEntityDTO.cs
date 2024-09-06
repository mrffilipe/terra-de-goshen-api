namespace TerraDeGoshenAPI.src.Application
{
    public interface IEntityDTO
    {
        Guid Id { get; }
        DateTime CreatedAt { get; }
        DateTime UpdatedAt { get; }
    }
}