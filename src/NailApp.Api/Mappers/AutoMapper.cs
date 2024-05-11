using AutoMapper;
using NailApp.Api.Models;
using NailApp.API.Models;
using NailApp.Services.Dtos;

namespace NorthwindApp.API.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<User, UserDto>();
            CreateMap<AuthenticateApiRequest, AuthenticateDtoRequest>().ReverseMap();
            CreateMap<AuthenticateApiResponse, AuthenticateDtoResponse>().ReverseMap();
        }
    }
}
