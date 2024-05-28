namespace TerraDeGoshenAPI.src.Application
{
    public record SizeUpdateDTO(
        Guid Id,
        string Value,
        bool IsDeleted = false
        );
}