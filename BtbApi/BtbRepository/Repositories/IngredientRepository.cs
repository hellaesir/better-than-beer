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
    public class IngredientRepository : IIngredientRepository
    {
        private readonly AppDbContext _context;

        public IngredientRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> Count()
        {
            return _context.Ingredients.CountAsync();
        }

        public async Task Create(Ingredient entity)
        {
            _context.Ingredients.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task<Ingredient> GetById(int id)
        {
            return _context.Ingredients.FirstOrDefaultAsync(f => f.Id == id);
        }

        public Task<List<Ingredient>> GetList(int pageIndex, int pageSize)
        {
            return _context.Ingredients.Skip((pageIndex-1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task Update(Ingredient entity)
        {
            var dbEntity = await _context.Ingredients.FirstOrDefaultAsync(f => f.Id == entity.Id); 
            if (dbEntity != null)
            {
                dbEntity.Name = entity.Name;
                await _context.SaveChangesAsync();
            }
        }
    }
}
