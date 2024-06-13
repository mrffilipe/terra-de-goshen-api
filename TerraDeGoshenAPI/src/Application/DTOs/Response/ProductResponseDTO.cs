namespace TerraDeGoshenAPI.src.Application
{
    public record ProductResponseDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public double Price { get; } = 0;
        public string BackgroundText { get; } = string.Empty;
        public IList<ImageResponseDTO> Images { get; } = [];
        public IList<ColorResponseDTO> Colors { get; } = [];
        public IList<SizeResponseDTO> Sizes { get; } = [];
        public CategoryResponseDTO Category { get; } = new CategoryResponseDTO();
        public int QuantityInStock { get; } = 0;
        public DateTime CreatedAt { get; } = DateTime.MinValue;
        public DateTime UpdatedAt { get; } = DateTime.MinValue;

        public ProductResponseDTO()
        { }

        public ProductResponseDTO(
            Guid id,
            string name,
            string description,
            double price,
            string backgroundText,
            IList<ImageResponseDTO> images,
            IList<ColorResponseDTO> colors,
            IList<SizeResponseDTO> sizes,
            CategoryResponseDTO category,
            int quantityInStock,
            DateTime createdAt,
            DateTime updatedAt
            )
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            BackgroundText = backgroundText;
            Images = images;
            Colors = colors;
            Sizes = sizes;
            Category = category;
            QuantityInStock = quantityInStock;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}