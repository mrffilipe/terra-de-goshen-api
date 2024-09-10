using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public record DebtCreateDTO(
        decimal TotalAmount,
        DateTime DueDate,
        int InstallmentCount,
        PaymentMethod PaymentMethod,
        decimal? InitialPayment,
        Guid CustomerId
    )
    {
        public decimal TotalAmount { get; init; } = TotalAmount;
        public DateTime DueDate { get; init; } = DueDate;
        public int InstallmentCount { get; init; } = InstallmentCount;
        public PaymentMethod PaymentMethod { get; init; } = PaymentMethod;
        public decimal? InitialPayment { get; init; } = InitialPayment;
        public Guid CustomerId { get; init; } = CustomerId;
    }
}