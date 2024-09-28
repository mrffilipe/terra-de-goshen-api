namespace TerraDeGoshenAPI.src.Domain
{
    public record SizeVO
    {
        public string Value { get; }

        public SizeVO(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value), "O valor do tamanho não pode ser nulo.");
        }
    }
}