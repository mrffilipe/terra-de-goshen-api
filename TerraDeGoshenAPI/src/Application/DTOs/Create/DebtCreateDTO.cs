using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public record DebtCreateDTO(
        decimal TotalAmount,
        DateTime DueDate,
        PaymentMethod PaymentMethod,
        Guid CustomerId
    )
    {
        public decimal TotalAmount { get; init; } = TotalAmount;
        public DateTime DueDate { get; init; } = DueDate;
        public PaymentMethod PaymentMethod { get; init; } = PaymentMethod;
        public Guid CustomerId { get; init; } = CustomerId;
    }
}