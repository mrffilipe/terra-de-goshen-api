namespace TerraDeGoshenAPI.src.Application
{
    public record ProductResponseDTO(
        Guid Id,
        string Name,
        string Description,
        decimal Price,
        decimal CostPrice,
        int Stock,
        IList<ImageResponseDTO> Images,
        IList<ColorResponseDTO> Colors,
        IList<SizeResponseDTO> Sizes,
        CategoryResponseDTO Category,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name ?? string.Empty;
        public string Description { get; } = Description ?? string.Empty;
        public decimal Price { get; } = Price;
        public decimal CostPrice { get; } = CostPrice;
        public int Stock { get; } = Stock;
        public IList<ImageResponseDTO> Images { get; } = Images;
        public IList<ColorResponseDTO> Colors { get; } = Colors;
        public IList<SizeResponseDTO> Sizes { get; } = Sizes;
        public CategoryResponseDTO Category { get; } = Category;
        public DateTime CreatedAt { get; } = CreatedAt;
        public DateTime UpdatedAt { get; } = UpdatedAt;
    }
}