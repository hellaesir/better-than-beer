using AutoMapper;
using BtbDomain.Bases;
using BtbDomain.DTOs;
using BtbDomain.DTOs.Creates;
using BtbRepository.Interfaces;
using BtbRepository.Repositories;
using BtbService.Bases;
using BtbService.Interfaces;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Services
{
    public class MeasureService : BaseService, IMeasureService
    {
        private readonly IMapper _mapper;
        private readonly IMeasureRepository _measureRepository;

        public MeasureService(IConfiguration configuration, IActiveUserService activeUserService, IMeasureRepository measureRepository, IMapper mapper) : base(configuration, activeUserService)
        {
            _measureRepository = measureRepository;
            _mapper = mapper;
        }

        public async Task Create(MeasureCreateDTO entity)
        {
            await _measureRepository.Create(_mapper.Map<Measure>(entity), ActiveUser);
        }

        public async Task<MeasureDTO> GetById(int id)
        {
            var ret = _mapper.Map<MeasureDTO>(await _measureRepository.GetById(id));
            return ret;
        }

        public async Task<BaseListResponse<MeasureDTO>> GetList(int pageIndex, int pageSize)
        {
            var ingredients = await _measureRepository.GetList(pageIndex, pageSize);

            var result = new BaseListResponse<MeasureDTO>()
            {
                Items = _mapper.Map<List<MeasureDTO>>(ingredients),
                Total = await _measureRepository.Count(),
                PageSize = pageSize,
                Page = pageIndex
            };

            return result;
        }

        public async Task Update(MeasureUpdateDTO entity)
        {
            await _measureRepository.Update(_mapper.Map<Measure>(entity), ActiveUser);
        }
    }
}
