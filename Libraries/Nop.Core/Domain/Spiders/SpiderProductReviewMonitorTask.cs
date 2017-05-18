using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public partial class SpiderProductReviewMonitorTask : BaseEntity
    {
        public string asin { get; set; }

        public string host { get; set; }

        public DateTime created { get; set; }
    }
}
