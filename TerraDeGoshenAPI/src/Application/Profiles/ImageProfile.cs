using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<ImageCreateDTO, ImageRef>();

            CreateMap<ImageRef, ImageResponseDTO>()
                .ConstructUsing(src => new ImageResponseDTO(src.Id, src.Details.Url, src.Details.IsCover, src.CreatedAt, src.UpdatedAt));
        }
    }
}