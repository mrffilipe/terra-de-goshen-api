namespace TerraDeGoshenAPI.src.Application
{
    public interface IBaseEntityDTO : IEntityDTO
    {
        Guid Id { get; }
        DateTime CreatedAt { get; }
        DateTime UpdatedAt { get; }
    }
}