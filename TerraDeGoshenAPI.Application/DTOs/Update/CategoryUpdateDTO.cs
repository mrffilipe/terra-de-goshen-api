namespace TerraDeGoshenAPI.Application
{
    public record CategoryUpdateDTO(
        Guid Id,
        string Name,
        bool IsDeleted = false
        );
}