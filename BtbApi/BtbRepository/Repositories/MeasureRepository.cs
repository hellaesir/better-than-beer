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
    public class MeasureRepository : IMeasureRepository
    {
        private readonly AppDbContext _context;

        public MeasureRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> Count()
        {
            return _context.Measures.CountAsync();
        }

        public async Task Create(Measure entity)
        {
            _context.Measures.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task<Measure> GetById(int id)
        {
            return _context.Measures.FirstOrDefaultAsync(f => f.Id == id);
        }

        public Task<List<Measure>> GetList(int pageIndex, int pageSize)
        {
            return _context.Measures.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task Update(Measure entity)
        {
            var dbEntity = await _context.Measures.FirstOrDefaultAsync(f => f.Id == entity.Id); 
            if (dbEntity != null)
            {
                dbEntity = entity;
                await _context.SaveChangesAsync();
            }
        }
    }
}
