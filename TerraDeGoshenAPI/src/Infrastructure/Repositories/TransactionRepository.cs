using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext _context;

        public TransactionRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();

            return transaction;
        }

        public async Task<Transaction> GetTransactionByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }

            var transaction = await _context.Transactions
                                            .Include(t => t.Customer)
                                            .Include(t => t.Product)
                                            .FirstOrDefaultAsync(t => t.Id == id);

            if (transaction == null)
            {
                throw new KeyNotFoundException($"Transação com ID {id} não encontrada.");
            }

            return transaction;
        }

        public async Task<IList<Transaction>> GetTransactionsByCustomerAsync(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new ArgumentException("ID do cliente inválido.", nameof(customerId));
            }

            return await _context.Transactions
                                 .Where(t => t.CustomerId == customerId)
                                 .Include(t => t.Customer)
                                 .Include(t => t.Product)
                                 .ToListAsync();
        }

        public async Task<IList<Transaction>> GetTransactionsByProductAsync(Guid productId)
        {
            if (productId == Guid.Empty)
            {
                throw new ArgumentException("ID do produto inválido.", nameof(productId));
            }

            return await _context.Transactions
                                 .Where(t => t.ProductId == productId)
                                 .Include(t => t.Customer)
                                 .Include(t => t.Product)
                                 .ToListAsync();
        }

        public async Task<IList<Transaction>> GetTransactionsByCashRegisterAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (cashRegisterId == Guid.Empty)
            {
                throw new ArgumentException("ID do caixa inválido.", nameof(cashRegisterId));
            }

            var query = _context.Transactions
                                .Where(t => t.CashRegisterId == cashRegisterId)
                                .Include(t => t.Customer)
                                .Include(t => t.Product)
                                .AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(t => t.CreatedAt >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(t => t.CreatedAt <= endDate.Value);
            }

            return await query.ToListAsync();
        }
    }
}