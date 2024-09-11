using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }

            var customer = await _context.Customers
                                         .Include(c => c.Debts)
                                         .Include(c => c.Transactions)
                                         .FirstOrDefaultAsync(c => c.Id == id);

            if (customer == null)
            {
                throw new KeyNotFoundException($"Cliente com ID {id} não encontrado.");
            }

            return customer;
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
                throw new ArgumentNullException(nameof(customer));
            }

            var existingCustomer = await _context.Customers
                                                 .FirstOrDefaultAsync(c => c.Id == customer.Id);

            if (existingCustomer == null)
            {
                throw new KeyNotFoundException($"Cliente com ID {customer.Id} não encontrado.");
            }

            existingCustomer.SetFirstName(customer.FirstName);
            existingCustomer.SetLastName(customer.LastName);

            _context.Entry(existingCustomer).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return existingCustomer;
        }
    }
}