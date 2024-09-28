using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class DebtRepository : IDebtRepository
    {
        private readonly ApplicationDbContext _context;

        public DebtRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context), "O contexto de banco de dados não pode ser nulo.");
        }

        public async Task<Debt> AddDebtAsync(Debt debt)
        {
            if (debt == null)
            {
                throw new ArgumentNullException(nameof(debt));
            }

            await _context.Debts.AddAsync(debt);
            await _context.SaveChangesAsync();

            return debt;
        }

        public async Task<Debt> GetDebtByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID do débito inválido.", nameof(id));
            }

            return await _context.Debts
                                     .Include(d => d.Installments)
                                     .Include(x => x.Customer)
                                     .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IList<Debt>> GetDebtsByCustomerIdAsync(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new ArgumentException("ID do cliente inválido.", nameof(customerId));
            }

            return await _context.Debts
                                     .Include(d => d.Installments)
                                     .Where(x => x.CustomerId == customerId)
                                     .ToListAsync();
        }

        public async Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null)
        {
            var query = _context.Debts.AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(d => d.DueDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(d => d.DueDate <= endDate.Value);
            }

            if (isPaid.HasValue)
            {
                query = query.Where(d => d.Installments.Any(i => i.IsPaid == isPaid.Value));
            }

            query = query.Include(d => d.Installments)
                         .Include(d => d.Customer);

            return await query.ToListAsync();

        }

        public async Task<Installment> GetInstallmentByIdAsync(Guid installmentId)
        {
            if (installmentId == Guid.Empty)
            {
                throw new ArgumentException("ID da parcela inválido.", nameof(installmentId));
            }

            return await _context.Installments
                                 .Include(i => i.Debt)
                                 .FirstOrDefaultAsync(i => i.Id == installmentId);
        }

        public async Task<Installment> UpdateInstallmentAsync(Installment installment)
        {
            if (installment == null)
            {
                throw new ArgumentNullException(nameof(installment), "A parcela não pode ser nulo.");
            }

            _context.Entry(installment).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return installment;
        }

    }
}