namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleSizeCreateDTO(Guid Id)
    {
        public Guid Id { get; init; } = Id;
    }
}