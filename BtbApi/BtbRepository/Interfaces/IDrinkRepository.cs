using BtbDomain.DTOs;
using BtbRepository.Base;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbRepository.Interfaces
{
    public interface IDrinkRepository : IBaseRepository<Drink>
    {
        Task<List<Drink>> GetByIngredientId(int ingredientId);
    }
}
