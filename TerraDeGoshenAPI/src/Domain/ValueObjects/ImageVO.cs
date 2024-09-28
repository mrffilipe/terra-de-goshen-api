namespace TerraDeGoshenAPI.src.Domain
{
    public record ImageVO
    {
        public string Url { get; }
        public bool? IsCover { get; }

        public ImageVO(string url, bool? isCover)
        {
            Url = url ?? throw new ArgumentNullException(nameof(url), "A URL da imagem não pode ser nula.");
            IsCover = isCover ?? throw new ArgumentNullException(nameof(isCover), "O valor de 'IsCover' não pode ser nulo.");
        }
    }
}