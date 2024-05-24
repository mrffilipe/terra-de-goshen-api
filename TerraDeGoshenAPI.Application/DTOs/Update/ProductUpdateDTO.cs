namespace TerraDeGoshenAPI.Application
{
    public record ProductUpdateDTO(
        Guid Id,
        string Name,
        string Description,
        double Price,
        IList<ImageUpdateDTO>? Images,
        IList<ColorUpdateDTO>? Colors,
        IList<SizeUpdateDTO>? Sizes,
        CategoryUpdateDTO? Category,
        int QuantityInStock,
        bool IsDeleted = false
        );
}