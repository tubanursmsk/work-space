using AutoMapper;
using MVC.Models;
using MVC.Dto.UserDto;

namespace MVC.Mappings
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            // User
            CreateMap<UserRegisterDto, User>();
           
        }
    }
}