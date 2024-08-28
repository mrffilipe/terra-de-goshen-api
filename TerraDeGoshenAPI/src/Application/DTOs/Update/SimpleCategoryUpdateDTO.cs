namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleCategoryUpdateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;

        public SimpleCategoryUpdateDTO()
        { }

        public SimpleCategoryUpdateDTO(Guid id)
        {
            Id = id;
        }
    }
}