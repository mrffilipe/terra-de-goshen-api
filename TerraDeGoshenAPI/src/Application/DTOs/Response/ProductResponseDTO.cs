namespace TerraDeGoshenAPI.src.Application
{
    public record ProductResponseDTO(
        Guid Id,
        string Name,
        string Description,
        double Price,
        IList<ImageResponseDTO> Images,
        IList<ColorResponseDTO> Colors,
        IList<SizeResponseDTO> Sizes,
        CategoryResponseDTO Category,
        int QuantityInStock,
        DateTime CreatedAt,
        DateTime UpdatedAt
        );
}