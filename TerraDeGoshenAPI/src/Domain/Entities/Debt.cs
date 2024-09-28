namespace TerraDeGoshenAPI.src.Domain
{
    public class Debt : BaseEntity
    {
        public MoneyVO TotalAmount { get; private set; }
        public DateTime DueDate { get; private set; }
        public int InstallmentCount { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public MoneyVO InitialPayment { get; private set; }
        public IList<Installment> Installments { get; private set; } = [];
        public Guid CustomerId { get; private set; }
        public Customer Customer { get; private set; } = null!;

        protected Debt() { }

        public Debt(
            MoneyVO totalAmount,
            DateTime dueDate,
            int installmentCount,
            PaymentMethod paymentMethod,
            MoneyVO initialPayment,
            List<Installment> installments,
            Guid customerId)
        {
            TotalAmount = totalAmount ?? throw new ArgumentNullException(nameof(totalAmount), "O valor total não pode ser nulo.");
            DueDate = dueDate;
            InstallmentCount = installmentCount <= 0 ? throw new ArgumentOutOfRangeException(nameof(installmentCount), "A quantidade de parcelas deve ser maior que zero.") : installmentCount;
            PaymentMethod = paymentMethod;
            InitialPayment = initialPayment ?? throw new ArgumentNullException(nameof(initialPayment), "O pagamento inicial não pode ser nulo.");
            Installments = installments ?? throw new ArgumentNullException(nameof(installments), "A lista de parcelas não pode ser nula.");
            CustomerId = customerId;
        }
    }
}