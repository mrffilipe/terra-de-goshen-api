namespace TerraDeGoshenAPI.src.Application
{
    public record SizeUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public bool IsDeleted { get; } = false;

        public SizeUpdateDTO()
        { }

        public SizeUpdateDTO(Guid id, bool isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
        }
    }
}