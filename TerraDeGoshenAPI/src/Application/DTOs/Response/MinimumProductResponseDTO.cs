namespace TerraDeGoshenAPI.src.Application
{
    public record MinimumProductResponseDTO(
        Guid Id,
        string Name,
        double Price,
        IList<ImageResponseDTO> Images,
        DateTime CreatedAt,
        DateTime UpdatedAt
        );
}