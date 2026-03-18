using AutoMapper;
using Usuarios_API.DTOs.UserDTOs;
using Usuarios_API.Model;

namespace Usuarios_API.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserCreateDTO, User>(); 
        CreateMap<UserUpdateDTO, User>(); 
        CreateMap<User, UserCreateDTO>(); 
        CreateMap<User, UserUpdateDTO>(); 
    }
}
