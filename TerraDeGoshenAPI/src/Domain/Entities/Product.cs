namespace TerraDeGoshenAPI.src.Domain
{
    public class Product : IEntity
    {
        public string Name { get; } = string.Empty;
        public string Description { get; } = string.Empty;
        public double Price { get; } = 0;
        public string BackgroundText { get; } = string.Empty;
        public IList<ImageRef> Images { get; } = [];
        public IList<ColorRef> Colors { get; } = [];
        public IList<SizeRef> Sizes { get; } = [];
        public Guid CategoryId { get; } = Guid.Empty;
        public CategoryRef Category { get; } = null!;
        public int QuantityInStock { get; } = 0;

        public Product()
        { }

        public Product(
            string name,
            string description,
            double price,
            string backgroundText,
            IList<ImageRef> images,
            IList<ColorRef> colors,
            IList<SizeRef> sizes,
            CategoryRef category,
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

        public Product(
            string name,
            string description,
            double price,
            string backgroundText,
            IList<ImageRef> images,
            IList<ColorRef> colors,
            IList<SizeRef> sizes,
            Guid categoryId,
            int quantityInStock
            ) : this(name, description, price, backgroundText, images, colors, sizes, null!, quantityInStock)
        {
            CategoryId = categoryId;
        }
    }
}