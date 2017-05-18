using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Autos
{
    public class AutoGetStockRecord
    {
        public int id { get; set; }

        public string error { get; set; }

        public int task_id { get; set; }

        public string taskid { get; set; }

        public string asin { get; set; }

        public int stock { get; set; }
    }

}
