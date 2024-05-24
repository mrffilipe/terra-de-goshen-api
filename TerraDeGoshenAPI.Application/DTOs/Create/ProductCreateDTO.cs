namespace TerraDeGoshenAPI.Application
{
    public record ProductCreateDTO(
        string Name,
        string Description,
        double Price,
        IList<ImageCreateDTO> Images,
        IList<ColorCreateDTO> Colors,
        IList<SizeCreateDTO> Sizes,
        CategoryCreateDTO Category,
        int QuantityInStock
        );
}