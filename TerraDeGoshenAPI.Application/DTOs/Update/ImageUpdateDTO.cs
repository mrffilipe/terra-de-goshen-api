using Microsoft.AspNetCore.Http;

namespace TerraDeGoshenAPI.Application
{
    public record ImageUpdateDTO(
        Guid Id,
        string Url,
        IFormFile? File = null,
        bool IsDeleted = false
        );
}