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
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName), "O nome não pode ser nulo.");
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName), "O sobrenome não pode ser nulo.");
        }

        public void SetFirstName(string firstName)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName), "O nome não pode ser nulo.");
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName), "O sobrenome não pode ser nulo.");
        }
    }
}