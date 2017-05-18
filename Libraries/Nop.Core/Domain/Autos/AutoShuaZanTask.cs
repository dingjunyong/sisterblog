using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Autos
{
    public partial class AutoShuaZanTask : BaseEntity
    {
        public string asin { get; set; }

        public string url { get; set; }

        public DateTime start_time { get; set; }

        public bool finished { get; set; }

        public DateTime finished_time { get; set; }

        public int num { get; set; }

        public int finished_num { get; set; }

        public string host { get; set; }

        public int retry { get; set; }


    }
}
