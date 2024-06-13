namespace TerraDeGoshenAPI.src.Application
{
    public record SizeUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Value { get; } = string.Empty;
        public bool IsDeleted { get; } = false;

        public SizeUpdateDTO()
        { }

        public SizeUpdateDTO(Guid id, string value, bool isDeleted)
        {
            Id = id;
            Value = value;
            IsDeleted = isDeleted;
        }
    }
}