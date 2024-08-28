namespace TerraDeGoshenAPI.src.Application
{
    public record ProductResponseDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public decimal Price { get; } = 0;
        public decimal CostPrice { get; } = 0;
        public string BackgroundText { get; } = string.Empty;
        public int Stock { get; } = 0;
        public IList<ImageResponseDTO> Images { get; } = [];
        public IList<ColorResponseDTO> Colors { get; } = [];
        public IList<SizeResponseDTO> Sizes { get; } = [];
        public CategoryResponseDTO Category { get; } = new CategoryResponseDTO();
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; }

        public ProductResponseDTO()
        { }

        public ProductResponseDTO(
            Guid id,
            string name,
            string description,
            decimal price,
            decimal costPrice,
            string backgroundText,
            int stock,
            IList<ImageResponseDTO> images,
            IList<ColorResponseDTO> colors,
            IList<SizeResponseDTO> sizes,
            CategoryResponseDTO category,
            DateTime createdAt,
            DateTime updatedAt
            )
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CostPrice = costPrice;
            BackgroundText = backgroundText;
            Stock = stock;
            Images = images;
            Colors = colors;
            Sizes = sizes;
            Category = category;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}