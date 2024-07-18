using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<ImageRef, ImageResponseDTO>()
                .ConstructUsing(s => new ImageResponseDTO(
                    s.Id,
                    s.Details.Url,
                    s.Details.IsCover,
                    s.CreatedAt,
                    s.UpdatedAt
                    ));
        }
    }
}