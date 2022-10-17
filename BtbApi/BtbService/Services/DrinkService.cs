using BtbDomain.Bases;
using BtbDomain.DTOs;
using BtbDomain.DTOs.Creates;
using BtbDomain.DTOs.Updates;
using BtbRepository.Interfaces;
using BtbService.Bases;
using BtbService.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Services
{
    public class DrinkService : BaseService, IDrinkService
    {
        private readonly IDrinkRepository _drinkRepository;
        public DrinkService(IConfiguration configuration, IActiveUserService activeUserService, IDrinkRepository drinkRepository) : base(configuration, activeUserService)
        {
            _drinkRepository = drinkRepository;
        }

        public Task Create(DrinkCreateDTO entity)
        {
            throw new NotImplementedException();
        }

        public async Task<DrinkDetailsDTO> GetById(int id)
        {
            var x= await _drinkRepository.GetById(id);
            return null;
        }

        public Task<BaseListResponse<DrinkDTO>> GetList(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task Update(DrinkUpdateDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
