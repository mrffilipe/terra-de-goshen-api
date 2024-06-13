namespace TerraDeGoshenAPI.src.Application
{
    public record CategoryUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public bool IsDeleted { get; } = false;

        public CategoryUpdateDTO()
        { }

        public CategoryUpdateDTO(Guid id, bool isDeleted)
        {
            Id = id;
            IsDeleted = isDeleted;
        }
    }
}