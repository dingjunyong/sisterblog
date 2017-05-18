using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Autos
{
    public partial class AutoBrowseTask : BaseEntity
    {
        public string guid { get; set; }

        public int device { get; set; }

        public string asin { get; set; }

        public string host { get; set; }

        public DateTime start_time { get; set; }

        public int statu { get; set; }

        public string message { get; set; }

        public DateTime execute_time { get; set; }

        public int retry { get; set; }

    

    }
}
