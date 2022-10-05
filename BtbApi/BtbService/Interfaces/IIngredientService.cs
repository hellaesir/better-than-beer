using BtbDomain.Bases;
using BtbDomain.DTOs;
using BtbDomain.DTOs.Creates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Interfaces
{
    public interface IIngredientService
    {
        Task Create(IngredientCreateDTO entity);
        Task Update(IngredientUpdateDTO entity);
        Task<IngredientDTO> GetById(int id);
        Task<BaseListResponse<IngredientDTO>> GetList(int pageIndex, int pageSize);
    }
}
