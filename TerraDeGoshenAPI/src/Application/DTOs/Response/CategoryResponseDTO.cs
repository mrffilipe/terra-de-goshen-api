namespace TerraDeGoshenAPI.src.Application
{
    public record CategoryResponseDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Name { get; } = string.Empty;
        public DateTime CreatedAt { get; } = DateTime.MinValue;
        public DateTime UpdatedAt { get; } = DateTime.MinValue;

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