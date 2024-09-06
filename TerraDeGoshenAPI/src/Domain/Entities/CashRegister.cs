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
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            Transactions.Add(transaction);

            UpdateCurrentBalance(transaction);
        }

        public MoneyVO GetCurrentBalance() => CurrentBalance;

        private void UpdateCurrentBalance(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            if (transaction.TransactionType == TransactionType.INCOME)
            {
                // Adiciona a quantia ao saldo atual
                CurrentBalance = CurrentBalance.Add(transaction.Amount);
            }
            else if (transaction.TransactionType == TransactionType.EXPENSE)
            {
                // Subtrai a quantia do saldo atual, com validação de saldo suficiente
                CurrentBalance = CurrentBalance.Subtract(transaction.Amount);
            }
            else
            {
                throw new InvalidOperationException("Tipo de transação desconhecido.");
            }
        }
    }
}