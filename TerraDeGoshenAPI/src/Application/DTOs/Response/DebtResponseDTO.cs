using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public record DebtResponseDTO(
        Guid Id,
        decimal TotalAmount,
        DateTime DueDate,
        PaymentMethod PaymentMethod,
        IList<InstallmentResponseDTO> Installments,
        CustomerResponseDTO Customer,
        DateTime CreatedAt,
        DateTime UpdatedAt

    ) : IEntityDTO
    {
        public Guid Id { get; init; } = Id;
        public decimal TotalAmount { get; init; } = TotalAmount;
        public DateTime DueDate { get; init; } = DueDate;
        public PaymentMethod PaymentMethod { get; init; } = PaymentMethod;
        public IList<InstallmentResponseDTO> Installments { get; init; } = Installments;
        public CustomerResponseDTO Customer { get; init; } = Customer;
        public DateTime CreatedAt { get; init; } = CreatedAt;
        public DateTime UpdatedAt { get; init; } = UpdatedAt;
    }
}