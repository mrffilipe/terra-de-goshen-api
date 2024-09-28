namespace TerraDeGoshenAPI.src.Domain
{
    public record ColorVO
    {
        public string Value { get; }

        public ColorVO(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value), "O valor da cor não pode ser nulo.");
        }
    }
}