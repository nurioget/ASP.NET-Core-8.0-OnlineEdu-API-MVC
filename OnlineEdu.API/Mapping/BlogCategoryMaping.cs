using AutoMapper;
using OnlineEdu.DTO.DTOs.BlogCategoryDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BlogCategoryMaping :Profile
    {
        public BlogCategoryMaping()
        {
            CreateMap<CreateBlogCategoryDto,BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogCategoryDto,BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDto,BlogCategory>().ReverseMap();
        }
    }
}
