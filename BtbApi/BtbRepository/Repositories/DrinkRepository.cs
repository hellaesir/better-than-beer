using BtbDomain.DTOs;
using BtbRepository.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbRepository.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _context;

        public DrinkRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> Count()
        {
            return _context.Drinks.CountAsync();
        }

        public Task Create(Drink entity, ActiveUserDTO activeUser)
        {
            entity.CreationUserId = activeUser.Id;
            entity.CreationDate = DateTime.Now;
            entity.UpdateUserId = activeUser.Id;
            entity.UpdateDate = DateTime.Now;
            entity.Active = true;

            _context.Drinks.Add(entity);
            return _context.SaveChangesAsync();
        }
        
        public Task<List<Drink>> GetAll()
        {
            return _context.Drinks.ToListAsync();
        }

        public Task<Drink> GetById(int id)
        {
            return _context.Drinks.FirstOrDefaultAsync(f => f.Id == id);
        }

        public Task<List<Drink>> GetByIngredientId(int ingredientId)
        {
            return _context.Drinks.Where(f => f.IngredientsMeasures.Any(g => g.IngredientId == ingredientId)).ToListAsync();
        }

        public Task<List<Drink>> GetList(int pageIndex, int pageSize)
        {
            return _context.Drinks.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
        }

        public Task Update(Drink entity, ActiveUserDTO activeUser)
        {
            entity.UpdateUserId = activeUser.Id;
            entity.UpdateDate = DateTime.Now;

            _context.Drinks.Update(entity);
            return _context.SaveChangesAsync();
        }
    }
}
