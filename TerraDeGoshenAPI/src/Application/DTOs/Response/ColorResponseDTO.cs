namespace TerraDeGoshenAPI.src.Application
{
    public record ColorResponseDTO(
        Guid Id,
        string Value,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; } = Id;
        public string Value { get; } = Value ?? string.Empty;
        public DateTime CreatedAt { get; } = CreatedAt;
        public DateTime UpdatedAt { get; } = UpdatedAt;
    }
}