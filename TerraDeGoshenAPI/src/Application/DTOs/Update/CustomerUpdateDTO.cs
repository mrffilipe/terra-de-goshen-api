namespace TerraDeGoshenAPI.src.Application
{
    public record CustomerUpdateDTO(
        Guid Id,
        string FirstName,
        string LastName
    )
    {
        public Guid Id { get; init; } = Id;
        public string FirstName { get; init; } = FirstName;
        public string LastName { get; init; } = LastName;
    }
}