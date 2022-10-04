using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Measure
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public eMeasureType Type { get; set; }
        [Required]
        public decimal Quantity { get; set; }
    }
}
