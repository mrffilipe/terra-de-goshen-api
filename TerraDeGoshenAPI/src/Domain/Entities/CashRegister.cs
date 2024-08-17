namespace TerraDeGoshenAPI.src.Domain
{
    public class CashRegister : BaseEntity
    {
        public MoneyVO CurrentBalance { get; private set; }

        public CashRegister(MoneyVO currentBalance)
        {
            CurrentBalance = currentBalance ?? throw new ArgumentNullException(nameof(currentBalance));
        }

        public void AddTransaction(Transaction transaction)
        {
        }

        public MoneyVO GetCurrentBalance() => CurrentBalance;
    }
}