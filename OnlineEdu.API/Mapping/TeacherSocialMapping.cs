using AutoMapper;
using OnlineEdu.DTO.DTOs.TeacherSocialDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class TeacherSocialMapping : Profile
    {
        public TeacherSocialMapping()
        {
            CreateMap<TeacherSocial,CreateTeacherSocialDto>().ReverseMap();
            CreateMap<TeacherSocial,ResultTeacherSocialDto>().ReverseMap();
            CreateMap<TeacherSocial,UpdateTeacherSocialDto>().ReverseMap();
        }
    }
}
