using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context), "O contexto de banco de dados não pode ser nulo.");
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "O cliente não pode ser nulo.");
            }

            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID do cliente inválido.", nameof(id));
            }

            return await _context.Customers
                                 .Include(c => c.Debts)
                                 .Include(c => c.Transactions)
                                 .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IList<Customer>> GetAllCustomersAsync()
        {
            return await _context.Customers
                                 .Include(c => c.Debts)
                                 .Include(c => c.Transactions)
                                 .ToListAsync();
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer), "O cliente não pode ser nulo.");
            }

            var existingCustomer = await _context.Customers
                                                 .FirstOrDefaultAsync(c => c.Id == customer.Id);

            if (existingCustomer == null)
            {
                return null;
            }

            existingCustomer.SetFirstName(customer.FirstName);
            existingCustomer.SetLastName(customer.LastName);

            _context.Entry(existingCustomer).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return existingCustomer;
        }
    }
}