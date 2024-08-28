namespace TerraDeGoshenAPI.src.Application
{
    public record ImageResponseDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Url { get; } = string.Empty;
        public bool? IsCover { get; } = false;
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }

        public ImageResponseDTO()
        { }

        public ImageResponseDTO(Guid id, string url, bool? isCover, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Url = url;
            IsCover = isCover;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}