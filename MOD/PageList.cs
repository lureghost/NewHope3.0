using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOD;

namespace MOD
{
   public class PageList
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int PageCount { get; set; }


        public IQueryable DateList { get; set; }
    }
}
