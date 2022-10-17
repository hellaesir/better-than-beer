using BtbDomain.Bases;
using BtbDomain.DTOs.Creates;
using BtbDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Interfaces
{
    public interface IMeasureService
    {
        Task Create(MeasureCreateDTO entity);
        Task Update(MeasureUpdateDTO entity);
        Task<MeasureDTO> GetById(int id);
        Task<BaseListResponse<MeasureDTO>> GetList(int pageIndex, int pageSize);
    }
}
