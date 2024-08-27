namespace TerraDeGoshenAPI.src.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public MoneyVO Price { get; private set; }
        public MoneyVO CostPrice { get; private set; }
        public string BackgroundText { get; private set; }
        public StockVO Stock { get; private set; }
        public IList<ImageRef> Images { get; private set; } = [];
        public IList<ColorRef> Colors { get; private set; } = [];
        public IList<SizeRef> Sizes { get; private set; } = [];
        public Guid CategoryId { get; private set; }
        public CategoryRef Category { get; private set; } = null!;
        public IList<Transaction> Transactions { get; private set; } = [];

        public Product(
            string name,
            string description,
            MoneyVO price,
            MoneyVO costPrice,
            string backgroundText,
            StockVO stock,
            IList<ImageRef> images,
            IList<ColorRef> colors,
            IList<SizeRef> sizes,
            Guid categoryId
            )
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price ?? throw new ArgumentNullException(nameof(price));
            CostPrice = costPrice ?? throw new ArgumentNullException(nameof(costPrice));
            BackgroundText = backgroundText ?? throw new ArgumentNullException(nameof(backgroundText));
            Stock = stock ?? throw new ArgumentNullException(nameof(stock));
            Images = images ?? throw new ArgumentNullException(nameof(images));
            Colors = colors ?? throw new ArgumentNullException(nameof(colors));
            Sizes = sizes ?? throw new ArgumentNullException(nameof(sizes));
            CategoryId = categoryId;
        }
    }
}