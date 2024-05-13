using AutoMapper;
using NailApp.Data.Entities;
using NailApp.Data.Interfaces;
using NailApp.Services.Dtos;
using NailApp.Services.Interfaces;

namespace NailApp.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;

        private readonly IRepository<UserEntity> _repository;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IRepository<UserEntity> repository, IUserRepository userRepository)
        {
            _mapper = mapper;
            _repository = repository;
            _userRepository = userRepository;
        }

        public AuthenticateResponse? Authenticate(AuthenticateRequest model)
        {
            var entity = _userRepository.Authenticate(model);
            return _mapper.Map<AuthenticateResponse>(entity);
        }

        public IEnumerable<UserDto> GetAll()
        {
            var result = _repository.GetAll().AsEnumerable<UserEntity>().ToList();
            return _mapper.Map<List<UserDto>>(result);
        }

        IEnumerable<UserDto> IUserService.SearchUserName(string str)
        {
            var entity = _userRepository.SearchUser(str);
            return _mapper.Map<List<UserDto>>(entity);
        }

        UserDto IUserService.GetUserById(int id)
        {
            var entity = _userRepository.GetUserById(id);
            return _mapper.Map<UserDto>(entity);
        }
    }
}
