using AutoMapper;
using OnlineEdu.DTO.DTOs.BannerDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BannerMaping : Profile
    {
        public BannerMaping()
        {
            CreateMap<CreateBannerDto,Banner>().ReverseMap();
            CreateMap<UpdateBannerDto,Banner>().ReverseMap();
        }
    }
}
