﻿namespace TerraDeGoshenAPI.src.Domain
{
    public record ImageVO(
        string Url,
        bool? IsCover = false
        );
}