namespace TerraDeGoshenAPI.src.Domain
{
    public class CashRegister : BaseEntity
    {
        public MoneyVO CurrentBalance { get; private set; }
        public IList<Transaction> Transactions { get; private set; } = [];

        protected CashRegister() { }

        public CashRegister(MoneyVO currentBalance)
        {
            CurrentBalance = currentBalance ?? throw new ArgumentNullException(nameof(currentBalance), "O saldo inicial não pode ser nulo.");
        }

        public CashRegister(Guid id, MoneyVO currentBalance) : this(currentBalance)
        {
            Id = id;
        }

        public void AddTransaction(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction), "A transação não pode ser nula.");

            Transactions.Add(transaction);
            UpdateCurrentBalance(transaction);
        }

        public MoneyVO GetCurrentBalance() => CurrentBalance;

        private void UpdateCurrentBalance(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction), "A transação não pode ser nula.");

            switch (transaction.TransactionType)
            {
                case TransactionType.INCOME:
                    CurrentBalance = CurrentBalance.Add(transaction.Amount);
                    break;
                case TransactionType.EXPENSE:
                    CurrentBalance = CurrentBalance.Subtract(transaction.Amount);
                    break;
                default:
                    throw new InvalidOperationException("Tipo de transação desconhecido.");
            }
        }
    }
}