namespace TerraDeGoshenAPI.src.Application
{
    public record ProductUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public double Price { get; } = 0;
        public string BackgroundText { get; } = string.Empty;
        public IList<ImageUpdateDTO> Images { get; } = [];
        public IList<ColorUpdateDTO> Colors { get; } = [];
        public IList<SizeUpdateDTO> Sizes { get; } = [];
        public CategoryUpdateDTO Category { get; } = new CategoryUpdateDTO();
        public int QuantityInStock { get; } = 0;
        public bool IsDeleted { get; } = false;

        public ProductUpdateDTO()
        { }

        public ProductUpdateDTO(
            Guid id,
            string name,
            string description,
            double price,
            string backgroundText,
            IList<ImageUpdateDTO> images,
            IList<ColorUpdateDTO> colors,
            IList<SizeUpdateDTO> sizes,
            CategoryUpdateDTO category,
            int quantityInStock,
            bool isDeleted
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
            IsDeleted = isDeleted;
        }
    }
}