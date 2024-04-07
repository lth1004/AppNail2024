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
        private readonly IUserRepository _UserRepository;

        public UserService(IMapper mapper, IRepository<UserEntity> repository, IUserRepository UserRepository)
        {
            _mapper = mapper;
            _repository = repository;
            _UserRepository = UserRepository;
        }
        public IEnumerable<UserDto> GetAll()
        {
            var result = _repository.GetAll().AsEnumerable<UserEntity>().ToList();
            return _mapper.Map<List<UserDto>>(result);
        }

        IEnumerable<UserDto> IUserService.SearchUserName(string str)
        {
            var entity = _UserRepository.SearchUser(str);
            return _mapper.Map<List<UserDto>>(entity);
        }
    }
}
