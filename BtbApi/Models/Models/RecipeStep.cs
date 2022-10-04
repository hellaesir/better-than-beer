using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.Models
{
    public class RecipeStep
    {
        [Key]
        public int Id { get; set; }
        public string Step { get; set; }
    }
}
