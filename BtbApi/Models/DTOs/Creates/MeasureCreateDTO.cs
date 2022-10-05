using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.DTOs.Creates
{
    public class MeasureDTO
    {
        public string Type { get; set; }
        public decimal Quantity { get; set; }
    }
}
