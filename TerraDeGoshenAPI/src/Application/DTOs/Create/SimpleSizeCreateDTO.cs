namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleSizeCreateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;

        public SimpleSizeCreateDTO()
        { }

        public SimpleSizeCreateDTO(Guid id)
        {
            Id = id;
        }
    }
}