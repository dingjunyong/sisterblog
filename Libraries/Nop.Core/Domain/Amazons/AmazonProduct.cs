using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public partial class AmazonProduct : BaseEntity
    {
        public int ProductReviewMonitorId { get; set; }

        public int AmazonShopId { get; set; }

        public string Asin { get; set; }

        public string Title { get; set; }

        public string PictureUrl { get; set; }

        public string Url { get; set; }

        public bool  Deleted { get; set; }

        public bool KeywordMonitorAdded { get; set; }

        public int ReviewAvgScoreNofityType { get; set; }

        public double UnderNofityTopAvgScore { get; set; }

        public double UnderNofityMostAvgScore { get; set; }

        public virtual AmazonShop AmazonShop { get; set; }

        public virtual ProductReviewMonitor ProductReviewMonitor { get; set; }

    }
}
