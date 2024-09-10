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
            Guid customerId
            )
        {
            TotalAmount = totalAmount ?? throw new ArgumentNullException(nameof(totalAmount));
            DueDate = dueDate;
            InstallmentCount = installmentCount;
            PaymentMethod = paymentMethod;
            InitialPayment = initialPayment;
            Installments = installments ?? throw new ArgumentNullException(nameof(totalAmount));
            CustomerId = customerId;
        }

        public string GetDetails() => "";

        public void AddInstallment(Installment installment)
        {
        }

        public bool IsFullyPaid()
        {
            return false;
        }
    }
}