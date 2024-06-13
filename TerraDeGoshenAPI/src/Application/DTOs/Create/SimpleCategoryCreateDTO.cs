namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleCategoryCreateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;

        public SimpleCategoryCreateDTO()
        { }

        public SimpleCategoryCreateDTO(Guid id)
        {
            Id = id;
        }
    }
}