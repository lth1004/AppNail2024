using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NailApp.Services.Dtos;
using NailApp.Services.Interfaces;

namespace NorthwindApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _UserService;
        private readonly IMapper _mapper;
        private readonly ILogger<UsersController> _logger;
        public UsersController(ILogger<UsersController> logger, IUserService UserService, IMapper mapper)
        {
            _logger = logger;
            _UserService = UserService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<UserDto> Get()
        {
            return _UserService.GetAll();
        }
        [HttpGet("Search/{keyword}")]
        public IEnumerable<UserDto> SearchUserName(string keyword)
        {
            return _UserService.SearchUserName(keyword);
        }


    }

}
