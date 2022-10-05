using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.Bases
{
    public class BaseListResponse<T>
    {
        public int Total { get; set; }
        public int Page { get; set; }
        public List<T> Items { get; set; }
        public int PageSize { get; set; }
    }
}
