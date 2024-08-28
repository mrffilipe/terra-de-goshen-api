namespace TerraDeGoshenAPI.src.Application
{
    public record SizeUpdateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;
        public bool IsDeleted { get; init; } = false;

        public SizeUpdateDTO()
        { }

        public SizeUpdateDTO(Guid id, bool isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
        }
    }
}