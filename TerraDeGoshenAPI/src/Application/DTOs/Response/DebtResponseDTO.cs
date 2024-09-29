using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public record DebtResponseDTO(
        Guid Id,
        decimal TotalAmount,
        DateTime DueDate,
        int InstallmentCount,
        PaymentMethod PaymentMethod,
        decimal? InitialPayment,
        IList<InstallmentResponseDTO> Installments,
        CustomerResponseDTO Customer,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; } = Id;
        public decimal TotalAmount { get; } = TotalAmount;
        public DateTime DueDate { get; } = DueDate;
        public int InstallmentCount { get; } = InstallmentCount;
        public PaymentMethod PaymentMethod { get; } = PaymentMethod;
        public decimal? InitialPayment { get; } = InitialPayment;
        public IList<InstallmentResponseDTO> Installments { get; } = Installments;
        public CustomerResponseDTO Customer { get; } = Customer;
        public DateTime CreatedAt { get; } = CreatedAt;
        public DateTime UpdatedAt { get; } = UpdatedAt;
    }
}