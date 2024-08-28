namespace TerraDeGoshenAPI.src.Application
{
    public record ProductCreateDTO
    {
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public decimal Price { get; init; } = 0;
        public decimal CostPrice { get; init; } = 0;
        public string BackgroundText { get; init; } = string.Empty;
        public int Stock { get; init; } = 0;
        public IList<ImageCreateDTO> Images { get; init; } = [];
        public IList<SimpleColorCreateDTO> Colors { get; init; } = [];
        public IList<SimpleSizeCreateDTO> Sizes { get; init; } = [];
        public SimpleCategoryCreateDTO Category { get; init; } = null!;

        public ProductCreateDTO()
        { }

        public ProductCreateDTO(
            string name,
            string description,
            decimal price,
            decimal costPrice,
            string backgroundText,
            int stock,
            IList<ImageCreateDTO> images,
            IList<SimpleColorCreateDTO> colors,
            IList<SimpleSizeCreateDTO> sizes,
            SimpleCategoryCreateDTO category
            )
        {
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
        }
    }
}