namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleCategoryCreateDTO(Guid Id)
    {
        public Guid Id { get; init; } = Id;
    }
}