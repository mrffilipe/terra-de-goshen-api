namespace TerraDeGoshenAPI.src.Application
{
    public record ProductCreateDTO
    {
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public double Price { get; } = 0;
        public string BackgroundText { get; } = string.Empty;
        public IList<ImageCreateDTO> Images { get; } = [];
        public IList<ColorCreateDTO> Colors { get; } = [];
        public IList<SizeCreateDTO> Sizes { get; } = [];
        public CategoryCreateDTO Category { get; } = new CategoryCreateDTO();
        public int QuantityInStock { get; } = 0;

        public ProductCreateDTO(
            string name,
            string description,
            double price,
            string backgroundText,
            IList<ImageCreateDTO> images,
            IList<ColorCreateDTO> colors,
            IList<SizeCreateDTO> sizes,
            CategoryCreateDTO category,
            int quantityInStock
            )
        {
            Name = name;
            Description = description;
            Price = price;
            BackgroundText = backgroundText;
            Images = images;
            Colors = colors;
            Sizes = sizes;
            Category = category;
            QuantityInStock = quantityInStock;
        }
    }
}