using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.DTOs
{
    public class DrinkDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainUrl { get; set; }
        public int GentleOrBooze { get; set; }
        public int SweetOrDry { get; set; }
    }
}
