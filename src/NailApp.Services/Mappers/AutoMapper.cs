using AutoMapper;
using NailApp.Data.Entities;
using NailApp.Services.Dtos;

namespace NailApp.Services.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UserDto, UserEntity>()
                .ReverseMap();

        }
    }
}
