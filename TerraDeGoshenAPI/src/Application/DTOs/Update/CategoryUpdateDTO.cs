namespace TerraDeGoshenAPI.src.Application
{
    public record CategoryUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Name { get; } = string.Empty;
        public bool IsDeleted { get; } = false;

        public CategoryUpdateDTO()
        { }

        public CategoryUpdateDTO(Guid id, string name, bool isDeleted)
        {
            Id = id;
            Name = name;
            IsDeleted = isDeleted;
        }
    }
}