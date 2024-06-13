namespace TerraDeGoshenAPI.src.Application
{
    public record MinimumProductResponseDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Name { get; } = string.Empty;
        public double Price { get; } = 0;
        public IList<ImageResponseDTO> Images { get; } = [];
        public DateTime CreatedAt { get; } = DateTime.MinValue;
        public DateTime UpdatedAt { get; } = DateTime.MinValue;

        public MinimumProductResponseDTO()
        { }

        public MinimumProductResponseDTO(Guid id, string name, double price, IList<ImageResponseDTO> images, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Price = price;
            Images = images;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}