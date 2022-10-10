using BtbDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Interfaces
{
    public interface IUserService
    {
        Task<UserAuthenticationDTO> Authenticate(string email, string password);
        Task<string> RetrieveRefreshToken(string email);
        Task RevokeRefreshToken(string email);
        Task SaveRefreshToken(string email, string refreshToken);
    }
}
