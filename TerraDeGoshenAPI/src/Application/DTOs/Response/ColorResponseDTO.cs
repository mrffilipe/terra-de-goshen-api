namespace TerraDeGoshenAPI.src.Application
{
    public record ColorResponseDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Value { get; } = string.Empty;
        public Guid? ImageId { get; } = Guid.Empty;
        public DateTime CreatedAt { get; } = DateTime.MinValue;
        public DateTime UpdatedAt { get; } = DateTime.MinValue;

        public ColorResponseDTO()
        { }

        public ColorResponseDTO(Guid id, string value, Guid? imageId, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Value = value;
            ImageId = imageId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}