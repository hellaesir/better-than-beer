using BtbDomain.DTOs;
using BtbService.Bases;
using BtbService.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IConfiguration configuration, IActiveUserService activeUserService) : base(configuration, activeUserService)
        {
        }

        public Task<UserAuthenticationDTO> Authenticate(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<string> RetrieveRefreshToken(string email)
        {
            throw new NotImplementedException();
        }

        public Task RevokeRefreshToken(string email)
        {
            throw new NotImplementedException();
        }

        public Task SaveRefreshToken(string email, string refreshToken)
        {
            throw new NotImplementedException();
        }
    }
}
