using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public partial class SpiderReviewMonitorTask : BaseEntity
    {
        public string shop_id { get; set; }

        public string host { get; set; }

        public string created { get; set; }

        public string shop_name { get; set; }
    }
}
 