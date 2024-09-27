namespace TerraDeGoshenAPI.src.Application
{
    public record ProductResponseDTO(
        Guid Id,
        string Name,
        string Description,
        decimal Price,
        decimal CostPrice,
        string BackgroundText,
        int Stock,
        //IList<ImageResponseDTO> Images,
        //IList<ColorResponseDTO> Colors,
        //IList<SizeResponseDTO> Sizes,
        CategoryResponseDTO Category,
        DateTime CreatedAt,
        DateTime UpdatedAt
        ) : IEntityDTO
    {
        public Guid Id { get; init; } = Id;
        public string Name { get; init; } = Name;
        public string Description { get; init; } = Description;
        public decimal Price { get; init; } = Price;
        public decimal CostPrice { get; init; } = CostPrice;
        public string BackgroundText { get; init; } = BackgroundText;
        public int Stock { get; init; } = Stock;
        //public IList<ImageResponseDTO> Images { get; init; } = Images;
        //public IList<ColorResponseDTO> Colors { get; init; } = Colors;
        //public IList<SizeResponseDTO> Sizes { get; init; } = Sizes;
        public CategoryResponseDTO Category { get; init; } = Category;
        public DateTime CreatedAt { get; init; } = CreatedAt;
        public DateTime UpdatedAt { get; init; } = UpdatedAt;
    }
}