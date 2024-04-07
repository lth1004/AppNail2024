using AutoMapper;
using NailApp.API.Models;
using NailApp.Services.Dtos;

namespace NorthwindApp.API.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UserRequest, UserDto>();
        }
    }
}
