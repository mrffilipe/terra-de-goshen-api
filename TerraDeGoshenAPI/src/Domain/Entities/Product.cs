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

        protected Product() { }

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
            Guid categoryId)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "O nome não pode ser nulo.");
            Description = description ?? throw new ArgumentNullException(nameof(description), "A descrição não pode ser nula.");
            Price = price ?? throw new ArgumentNullException(nameof(price), "O preço não pode ser nulo.");
            CostPrice = costPrice ?? throw new ArgumentNullException(nameof(costPrice), "O custo não pode ser nulo.");
            BackgroundText = backgroundText ?? throw new ArgumentNullException(nameof(backgroundText), "O texto de fundo não pode ser nulo.");
            Stock = stock ?? throw new ArgumentNullException(nameof(stock), "O estoque não pode ser nulo.");
            Images = images ?? throw new ArgumentNullException(nameof(images), "A lista de imagens não pode ser nula.");
            Colors = colors ?? throw new ArgumentNullException(nameof(colors), "A lista de cores não pode ser nula.");
            Sizes = sizes ?? throw new ArgumentNullException(nameof(sizes), "A lista de tamanhos não pode ser nula.");
            CategoryId = categoryId;
        }
    }
}