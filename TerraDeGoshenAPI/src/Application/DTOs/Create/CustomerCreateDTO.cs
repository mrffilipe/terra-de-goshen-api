namespace TerraDeGoshenAPI.src.Application
{
    public record CustomerCreateDTO(
        string FirstName,
        string LastName)
    {
        public string FirstName { get; init; } = FirstName ?? string.Empty;
        public string LastName { get; init; } = LastName ?? string.Empty;
    }
}