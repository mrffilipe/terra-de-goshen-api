namespace TerraDeGoshenAPI.src.Domain
{
    public class Product : IEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public double Price { get; private set; } = 0;
        public string BackgroundText { get; private set; } = string.Empty;
        public IList<ImageRef> Images { get; private set; } = [];
        public IList<ColorRef> Colors { get; private set; } = [];
        public IList<SizeRef> Sizes { get; private set; } = [];
        public Guid CategoryId { get; private set; } = Guid.Empty;
        public CategoryRef Category { get; private set; } = null!;
        public int QuantityInStock { get; private set; } = 0;

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

        public void UpdateColors(IList<ColorRef> colors)
        {
            Colors = colors;
        }

        public void UpdateSizes(IList<SizeRef> sizes)
        {
            Sizes = sizes;
        }
    }
}