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

        public MoneyVO Add(MoneyVO other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            return new MoneyVO(Amount + other.Amount);
        }

        public MoneyVO Subtract(MoneyVO other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            if (other.Amount > Amount)
                throw new InvalidOperationException("Subtraction would result in negative balance");

            return new MoneyVO(Amount - other.Amount);
        }
    }
}