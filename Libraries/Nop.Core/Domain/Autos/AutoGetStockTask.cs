using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Autos
{
    public class AutoGetStockTask 
    {
        public int id { get; set; }
        public string taskid { get; set; }

        public string info { get; set; }

        public string asin { get; set; }

        public string shop_name { get; set; }

        public string host { get; set; }

        public DateTime start_time { get; set; }

        public bool finished { get; set; }

        public DateTime finished_time { get; set; }

        public int retry { get; set; }
    }
}
