namespace TerraDeGoshenAPI.src.Domain
{
    public class Transaction : BaseEntity
    {
        public MoneyVO Amount { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public Guid CashRegisterId { get; private set; }
        public CashRegister CashRegister { get; private set; } = null!;
        public Guid? ProductId { get; private set; }
        public Product? Product { get; private set; } = null!;
        public Guid? CustomerId { get; private set; }
        public Customer? Customer { get; private set; } = null!;

        protected Transaction() { }

        public Transaction(MoneyVO amount, TransactionType transactionType, PaymentMethod paymentMethod, Guid cashRegisterId, Guid? productId, Guid? customerId)
        {
            Amount = amount ?? throw new ArgumentNullException(nameof(amount), "O valor da transação não pode ser nulo.");
            TransactionType = transactionType;
            PaymentMethod = paymentMethod;
            CashRegisterId = cashRegisterId;
            ProductId = productId;
            CustomerId = customerId;
        }

        public void SetCashRegisterId(Guid cashRegisterId)
        {
            CashRegisterId = cashRegisterId;
        }
    }
}