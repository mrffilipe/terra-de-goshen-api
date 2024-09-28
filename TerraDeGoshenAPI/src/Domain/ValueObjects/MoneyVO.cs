namespace TerraDeGoshenAPI.src.Domain
{
    public record MoneyVO
    {
        public decimal Amount { get; }

        public MoneyVO(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "O valor não pode ser negativo.");

            Amount = amount;
        }

        public MoneyVO Add(MoneyVO other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other), "O valor a ser adicionado não pode ser nulo.");

            return new MoneyVO(Amount + other.Amount);
        }

        public MoneyVO Subtract(MoneyVO other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other), "O valor a ser subtraído não pode ser nulo.");

            if (other.Amount > Amount)
                throw new InvalidOperationException("A subtração resultaria em saldo negativo.");

            return new MoneyVO(Amount - other.Amount);
        }
    }
}