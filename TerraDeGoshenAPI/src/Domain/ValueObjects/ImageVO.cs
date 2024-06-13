namespace TerraDeGoshenAPI.src.Domain
{
    public record ImageVO
    {
        public string Url { get; } = string.Empty;
        public bool? IsCover { get; } = false;

        public ImageVO()
        { }

        public ImageVO(string url, bool? isCover = false)
        {
            Url = url;
            IsCover = isCover;
        }
    }
}