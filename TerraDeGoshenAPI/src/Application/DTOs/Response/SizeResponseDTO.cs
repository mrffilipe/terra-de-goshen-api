namespace TerraDeGoshenAPI.src.Application
{
    public record SizeResponseDTO(
    Guid Id,
    string Value,
    DateTime CreatedAt,
    DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; set; } = Id;
        public string Value { get; set; } = Value ?? string.Empty;
        public DateTime CreatedAt { get; set; } = CreatedAt;
        public DateTime UpdatedAt { get; set; } = UpdatedAt;
    }
}