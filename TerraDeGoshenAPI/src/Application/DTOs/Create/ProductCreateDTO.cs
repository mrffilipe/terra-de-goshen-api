namespace TerraDeGoshenAPI.src.Application
{
    public record ProductCreateDTO(
        string Name,
        string Description,
        decimal Price,
        decimal CostPrice,
        int Stock,
        IList<ImageCreateDTO> Images,
        IList<SimpleColorCreateDTO> Colors,
        IList<SimpleSizeCreateDTO> Sizes,
        SimpleCategoryCreateDTO Category)
    {
        public string Name { get; init; } = Name ?? string.Empty;
        public string Description { get; init; } = Description ?? string.Empty;
        public decimal Price { get; init; } = Price;
        public decimal CostPrice { get; init; } = CostPrice;
        public int Stock { get; init; } = Stock;
        public IList<ImageCreateDTO> Images { get; init; } = Images;
        public IList<SimpleColorCreateDTO> Colors { get; init; } = Colors;
        public IList<SimpleSizeCreateDTO> Sizes { get; init; } = Sizes;
        public SimpleCategoryCreateDTO Category { get; init; } = Category;
    }
}