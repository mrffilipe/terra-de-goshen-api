namespace TerraDeGoshenAPI.src.Application
{
    public record CategoryResponseDTO(
        Guid Id,
        string Name,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; } = Id;
        public string Name { get; init; } = Name ?? string.Empty;
        public DateTime CreatedAt { get; } = CreatedAt;
        public DateTime UpdatedAt { get; } = UpdatedAt;
    }
}