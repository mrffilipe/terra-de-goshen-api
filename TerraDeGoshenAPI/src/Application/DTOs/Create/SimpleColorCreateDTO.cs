namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleColorCreateDTO(Guid Id)
    {
        public Guid Id { get; init; } = Id;
    }
}