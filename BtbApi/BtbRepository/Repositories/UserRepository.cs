using BtbDomain.DTOs;
using BtbDomain.Models;
using BtbRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbRepository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> Count()
        {
            return _context.Users.CountAsync();
        }

        public Task Create(User entity, ActiveUserDTO activeUser)
        {
            //entity.CreationUserId = activeUser.Id;
            //entity.CreationDate = DateTime.Now;
            //entity.UpdateUserId = activeUser.Id;
            //entity.UpdateDate = DateTime.Now;
            //entity.Active = true;

            _context.Users.Add(entity);
            return _context.SaveChangesAsync();
        }

        public Task<User> FindById(int id)
        {
            return _context.Users.FirstOrDefaultAsync(f => f.Equals(id));
        }

        public Task<User> GetById(int id)
        {
            return _context.Users.FirstOrDefaultAsync(f => f.Id == id);
        }

        public Task<List<User>> GetList(int pageIndex, int pageSize)
        {
            return _context.Users.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
        }

        public Task Update(User entity, ActiveUserDTO activeUser)
        {
            //entity.UpdateUserId = activeUser.Id;
            //entity.UpdateDate = DateTime.Now;

            _context.Users.Update(entity);
            return _context.SaveChangesAsync();
        }
    }
}
