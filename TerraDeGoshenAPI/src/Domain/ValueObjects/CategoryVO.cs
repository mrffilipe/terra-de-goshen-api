namespace TerraDeGoshenAPI.src.Domain
{
    public record CategoryVO
    {
        public string Name { get; }

        public CategoryVO(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "O nome da categoria não pode ser nulo.");
        }
    }
}