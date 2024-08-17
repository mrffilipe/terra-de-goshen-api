namespace TerraDeGoshenAPI.src.Domain
{
    public class Transaction : BaseEntity
    {
        public MoneyVO Amount { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public Guid ProductId { get; private set; }
        public Product Product { get; private set; } = null!;
        public Guid CustomerID { get; private set; }
        public Customer Customer { get; private set; } = null!;

        public Transaction(MoneyVO amount, TransactionType transactionType, PaymentMethod paymentMethod, Guid productId, Guid customerID)
        {
            Amount = amount ?? throw new ArgumentNullException(nameof(amount));
            TransactionType = transactionType;
            PaymentMethod = paymentMethod;
            ProductId = productId;
            CustomerID = customerID;
        }

        public string GetDetails() => "";
    }
}