using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class DebtRepository : IDebtRepository
    {
        private readonly ApplicationDbContext _context;

        public DebtRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
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
                throw new ArgumentException("ID inválido.", nameof(id));
            }

            var debt = await _context.Debts
                                     .Include(d => d.Installments)
                                     .Include(x => x.Customer)
                                     .FirstOrDefaultAsync(d => d.Id == id);

            if (debt == null)
            {
                throw new KeyNotFoundException($"Dívida com ID {id} não encontrada.");
            }

            return debt;
        }

        public async Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null)
        {
            var query = _context.Debts
                .Include(d => d.Installments)
                .Include(x=>x.Customer)
                .AsQueryable();

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
                query = query.Where(d => d.Installments.All(i => i.IsPaid == isPaid.Value));
            }

            return await query.ToListAsync();
        }

        public async Task<Installment> GetInstallmentByIdAsync(Guid installmentId)
        {
            return await _context.Installments
                                 .Include(i => i.Debt)
                                 .FirstOrDefaultAsync(i => i.Id == installmentId);
        }

        public async Task<Installment> UpdateInstallmentAsync(Installment installment)
        {
            if (installment == null)
            {
                throw new ArgumentNullException(nameof(installment));
            }

            var existingInstallment = await _context.Installments
                                                    .FirstOrDefaultAsync(i => i.Id == installment.Id);

            if (existingInstallment == null)
            {
                throw new KeyNotFoundException($"Parcela com ID {installment.Id} não encontrada.");
            }

            _context.Entry(existingInstallment).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return existingInstallment;
        }

    }
}