using BtbDomain.Bases;
using BtbDomain.DTOs.Creates;
using BtbDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BtbDomain.DTOs.Updates;

namespace BtbService.Interfaces
{
    public interface IDrinkService  
    {
        Task Create(DrinkCreateDTO entity);
        Task Update(DrinkUpdateDTO entity);
        Task<DrinkDetailsDTO> GetById(int id);
        Task<BaseListResponse<DrinkDTO>> GetList(int pageIndex, int pageSize);
    }
}
