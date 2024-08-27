namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICashRegisterRepository
    {
        Task<CashRegister> GetByIdAsync(Guid id);
        Task<CashRegister> UpdateAsync(CashRegister cashRegister);
    }
}