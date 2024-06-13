namespace TerraDeGoshenAPI.src.Application
{
    public record ProductCreateDTO
    {
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public double Price { get; init; } = 0;
        public string BackgroundText { get; init; } = string.Empty;
        public IList<ImageCreateDTO> Images { get; init; } = [];
        public IList<SimpleColorCreateDTO> Colors { get; init; } = [];
        public IList<SimpleSizeCreateDTO> Sizes { get; init; } = [];
        public Guid CategoryId { get; init; } = Guid.Empty;
        public int QuantityInStock { get; init; } = 0;

        public ProductCreateDTO()
        { }

        public ProductCreateDTO(
            string name,
            string description,
            double price,
            string backgroundText,
            IList<ImageCreateDTO> images,
            IList<SimpleColorCreateDTO> colors,
            IList<SimpleSizeCreateDTO> sizes,
            Guid categoryId,
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
            CategoryId = categoryId;
            QuantityInStock = quantityInStock;
        }
    }
}