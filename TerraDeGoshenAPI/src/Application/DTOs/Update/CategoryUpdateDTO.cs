namespace TerraDeGoshenAPI.src.Application
{
    public record CategoryUpdateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;
        public bool IsDeleted { get; init; } = false;

        public CategoryUpdateDTO()
        { }

        public CategoryUpdateDTO(Guid id, bool isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
        }
    }
}