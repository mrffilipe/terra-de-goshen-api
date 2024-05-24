namespace TerraDeGoshenAPI.Application
{
    public record ColorUpdateDTO(
        Guid Id,
        string Value,
        Guid? ImageId,
        bool IsDeleted = false
        );
}