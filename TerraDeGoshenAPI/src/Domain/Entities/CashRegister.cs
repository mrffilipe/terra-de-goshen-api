namespace TerraDeGoshenAPI.src.Domain
{
    public class CashRegister : BaseEntity
    {
        public MoneyVO CurrentBalance { get; private set; }
        public IList<Transaction> Transactions { get; private set; } = [];

        protected CashRegister() { }

        public CashRegister(MoneyVO currentBalance)
        {
            CurrentBalance = currentBalance ?? throw new ArgumentNullException(nameof(currentBalance));
        }

        public CashRegister(Guid id, MoneyVO currentBalance) : this(currentBalance)
        {
            Id = id;
        }

        public void AddTransaction(Transaction transaction)
        {
        }

        public MoneyVO GetCurrentBalance() => CurrentBalance;
    }
}