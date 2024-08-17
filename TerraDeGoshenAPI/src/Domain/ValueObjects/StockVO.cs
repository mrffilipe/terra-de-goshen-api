namespace TerraDeGoshenAPI.src.Domain
{
    public record StockVO
    {
        public int Amount { get; }

        public StockVO(int amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Stock cannot be negative");

            Amount = amount;
        }
    }
}