namespace TerraDeGoshenAPI.src.Application
{
    public record ImageResponseDTO(
        Guid Id,
        string Url,
        bool? IsCover,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; } = Id;
        public string Url { get; } = Url ?? string.Empty;
        public bool? IsCover { get; } = IsCover;
        public DateTime CreatedAt { get; } = CreatedAt;
        public DateTime UpdatedAt { get; } = UpdatedAt;
    }
}