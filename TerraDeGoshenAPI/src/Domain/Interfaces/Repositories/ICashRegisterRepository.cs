namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICashRegisterRepository
    {
        Task<CashRegister> GetByIdAsync(Guid id);
        Task UpdateAsync(CashRegister cashRegister);
    }
}