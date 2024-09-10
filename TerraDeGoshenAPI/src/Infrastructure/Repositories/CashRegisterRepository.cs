using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CashRegisterRepository : ICashRegisterRepository
    {
        private readonly ApplicationDbContext _context;

        public CashRegisterRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            var cashRegister = await _context.CashRegisters
                                             .Include(c => c.Transactions)
                                             .FirstOrDefaultAsync(c => c.Id == transaction.CashRegisterId);

            if (cashRegister == null)
            {
                throw new KeyNotFoundException($"Caixa com ID {transaction.CashRegisterId} não encontrado.");
            }

            cashRegister.AddTransaction(transaction);

            await _context.Transactions.AddAsync(transaction);

            _context.Entry(cashRegister).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return transaction;
        }

        public async Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId)
        {
            var cashRegister = await _context.CashRegisters
                                             .FirstOrDefaultAsync(c => c.Id == cashRegisterId);

            if (cashRegister == null)
            {
                throw new KeyNotFoundException($"Caixa com ID {cashRegisterId} não encontrado.");
            }

            return cashRegister.GetCurrentBalance();
        }

        public async Task<IList<Transaction>> GetTransactionsAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            var query = _context.Transactions
                                .Where(t => t.CashRegisterId == cashRegisterId)
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