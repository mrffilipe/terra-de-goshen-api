namespace TerraDeGoshenAPI.src.Application
{
    public record SizeResponseDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Value { get; } = string.Empty;
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }

        public SizeResponseDTO()
        { }

        public SizeResponseDTO(Guid id, string value, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Value = value;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}