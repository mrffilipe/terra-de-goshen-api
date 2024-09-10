namespace TerraDeGoshenAPI.src.Domain
{
    public class Installment : BaseEntity
    {
        public MoneyVO Amount { get; private set; }
        public DateTime DueDate { get; private set; }
        public MoneyVO AmountPaid { get; private set; }
        public bool IsPaid { get; private set; }
        public Guid DebitId { get; private set; }
        public Debt Debt { get; private set; } = null!;

        protected Installment() { }

        public Installment(MoneyVO amount, MoneyVO amountPaid, bool isPaid, Guid debitId)
        {
            Amount = amount ?? throw new ArgumentNullException(nameof(amount));
            AmountPaid = amountPaid ?? throw new ArgumentNullException(nameof(amountPaid));
            IsPaid = isPaid;
            DebitId = debitId;
        }

        public void SetDueDate(DateTime dueDate)
        {
            DueDate = dueDate;
        }

        public void AddPayment(MoneyVO paymentAmount)
        {
            if (paymentAmount == null)
            {
                throw new ArgumentNullException(nameof(paymentAmount));
            }

            AmountPaid = AmountPaid.Add(paymentAmount);

            if (AmountPaid.Amount >= Amount.Amount)
            {
                MarkAsPaid();
            }
        }

        public void MarkAsPaid()
        {
            IsPaid = true;
        }

        public void SetAmountPaid(MoneyVO amountPaid)
        {
            AmountPaid = amountPaid;
        }
    }
}