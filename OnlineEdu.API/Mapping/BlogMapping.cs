using AutoMapper;
using OnlineEdu.DTO.DTOs.BannerDTOs;
using OnlineEdu.DTO.DTOs.BlogDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BlogMapping:Profile
    {
        public BlogMapping()
        {
            CreateMap<CreateBannerDto,Blog>().ReverseMap();
            CreateMap<UpdateBannerDto,Blog>().ReverseMap();
            CreateMap<ResultBlogDto,Blog>().ReverseMap();
        }
    }
}
