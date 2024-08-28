namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleSizeUpdateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;

        public SimpleSizeUpdateDTO()
        { }

        public SimpleSizeUpdateDTO(Guid id)
        {
            Id = id;
        }
    }
}