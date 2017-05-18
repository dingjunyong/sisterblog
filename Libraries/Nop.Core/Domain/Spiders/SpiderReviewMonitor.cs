using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public partial class SpiderReviewMonitor : BaseEntity
    {
        public int index { get; set; }

        public string star { get; set; }

        public string author_id { get; set; }

        public string author_name { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public int helpful { get; set; }

        public bool verified_purchase { get; set; }

        public string review_date { get; set; }

        public string type { get; set; }

        public string asin { get; set; }

        public string shop_id { get; set; }

        public string host { get; set; }

        public DateTime created { get; set; }

        public int review_count { get; set; }

        public string url { get; set; }

    }
}
