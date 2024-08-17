namespace TerraDeGoshenAPI.src.Domain
{
    public record MoneyVO
    {
        public decimal Amount { get; }

        public MoneyVO(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Money cannot be negative");

            Amount = amount;
        }
    }
}