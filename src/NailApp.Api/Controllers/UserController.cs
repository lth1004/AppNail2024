using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NailApp.Data.Authorization;
using NailApp.Data.Entities;
using NailApp.Services.Dtos;
using NailApp.Services.Interfaces;

namespace NorthwindApp.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _UserService;
        private readonly IMapper _mapper;
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger, IUserService UserService, IMapper mapper)
        {
            _logger = logger;
            _UserService = UserService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _UserService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [HttpGet]
        public IEnumerable<UserDto> Get()
        {
            return _UserService.GetAll();
        }

        [HttpGet("{id}")]
        public UserDto GetUserById(int id)
        {
            return _UserService.GetUserById(id);
        }

        [HttpGet("Search/{keyword}")]
        public IEnumerable<UserDto> SearchUserName(string keyword)
        {
            return _UserService.SearchUserName(keyword);
        }
    }
}
