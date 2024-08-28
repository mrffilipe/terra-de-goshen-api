namespace TerraDeGoshenAPI.src.Application
{
    public record ProductUpdateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public decimal Price { get; init; } = 0;
        public decimal CostPrice { get; init; } = 0;
        public string BackgroundText { get; init; } = string.Empty;
        public int Stock { get; init; } = 0;
        public IList<ImageUpdateDTO> Images { get; init; } = [];
        public IList<SimpleColorUpdateDTO> Colors { get; init; } = [];
        public IList<SimpleSizeUpdateDTO> Sizes { get; init; } = [];
        public SimpleCategoryUpdateDTO Category { get; init; } = null!;
        public bool IsDeleted { get; init; } = false;

        public ProductUpdateDTO()
        { }

        public ProductUpdateDTO(
            Guid id,
            string name,
            string description,
            decimal price,
            decimal costPrice,
            string backgroundText,
            int stock,
            IList<ImageUpdateDTO> images,
            IList<SimpleColorUpdateDTO> colors,
            IList<SimpleSizeUpdateDTO> sizes,
            SimpleCategoryUpdateDTO category,
            bool isDeleted
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
            IsDeleted = isDeleted;
        }
    }
}