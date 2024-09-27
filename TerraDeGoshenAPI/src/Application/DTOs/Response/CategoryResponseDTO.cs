namespace TerraDeGoshenAPI.src.Application
{
    public record CategoryResponseDTO
    {
        public Guid Id { get; init; } = Guid.Empty;
        public string Name { get; init; } = string.Empty;
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }

        public CategoryResponseDTO()
        { }

        public CategoryResponseDTO(Guid id, string name, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}