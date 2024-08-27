using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CashRegisterRepository : ICashRegisterRepository
    {
        public async Task<CashRegister> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<CashRegister> UpdateAsync(CashRegister cashRegister)
        {
            throw new NotImplementedException();
        }
    }
}