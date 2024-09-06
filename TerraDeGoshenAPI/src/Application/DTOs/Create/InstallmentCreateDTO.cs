namespace TerraDeGoshenAPI.src.Application
{
    public record InstallmentCreateDTO(
        decimal Amount,
        Guid DebitId
    )
    {
        public decimal Amount { get; init; } = Amount;
        public Guid DebitId { get; init; } = DebitId;
    }
}