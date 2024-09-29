namespace TerraDeGoshenAPI.src.Application
{
    public record CustomerResponseDTO(
        Guid Id,
        string FirstName,
        string LastName,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; } = Id;
        public string FirstName { get; } = FirstName ?? string.Empty;
        public string LastName { get; } = LastName ?? string.Empty;
        public DateTime CreatedAt { get; init; } = CreatedAt;
        public DateTime UpdatedAt { get; } = UpdatedAt;
    }
}