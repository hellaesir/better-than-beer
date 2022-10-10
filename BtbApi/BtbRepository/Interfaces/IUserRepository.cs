using BtbDomain.Models;
using BtbRepository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbRepository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> FindById(int id);
    }
}
