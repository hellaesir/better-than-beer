using AutoMapper;
using BtbDomain.DTOs;
using BtbRepository.Interfaces;
using BtbService.Bases;
using BtbService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace BtbService.Services
{
    public class ActiveUserService : BaseService, IActiveUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public ActiveUserService(IConfiguration configuration, IMapper mapper, IHttpContextAccessor httpContextAccessor, IUserRepository userRepository) : base(configuration, null)
        {
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<ActiveUserDTO> GetSystemUser()
        {
            var user = await _userRepository.FindById(1);

            return _mapper.Map<ActiveUserDTO>(user);
        }

        public async Task<ActiveUserDTO> GetUser()
        {
            if (_httpContextAccessor.HttpContext != null && _httpContextAccessor.HttpContext.User != null && _httpContextAccessor.HttpContext.User.Identity != null)
            {
                var user = await _userRepository.FindById(int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name));

                return _mapper.Map<ActiveUserDTO>(user);
            }

            return null;
        }
    }
}
