namespace TerraDeGoshenAPI.src.Domain
{
    public class Installment : BaseEntity
    {
        public MoneyVO Amount { get; private set; }
        public DateTime DueDate { get; private set; }
        public MoneyVO AmountPaid { get; private set; }
        public bool IsPaid { get; private set; }

        public Installment(MoneyVO amount, DateTime dueDate, MoneyVO amountPaid, bool isPaid)
        {
            Amount = amount ?? throw new ArgumentNullException(nameof(amount));
            DueDate = dueDate;
            AmountPaid = amountPaid ?? throw new ArgumentNullException(nameof(amountPaid));
            IsPaid = isPaid;
        }

        public void MarkAsPaid()
        {
        }
    }
}