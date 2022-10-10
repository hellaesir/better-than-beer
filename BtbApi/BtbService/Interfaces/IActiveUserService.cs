using BtbDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Interfaces
{
    public interface IActiveUserService
    {
        Task<ActiveUserDTO> GetUser();
        Task<ActiveUserDTO> GetSystemUser();
    }
}
