namespace TerraDeGoshenAPI.src.Domain
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public IList<Debt> Debts { get; private set; } = [];
        public IList<Transaction> Transactions { get; private set; } = [];

        protected Customer() { }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
    }
}