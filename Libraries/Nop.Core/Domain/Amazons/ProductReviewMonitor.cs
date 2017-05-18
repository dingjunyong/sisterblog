using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public partial class ProductReviewMonitor : BaseEntity
    {
        public double TopReviewAvgScore { get; set; }

        public double MostReviewAvgScore { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime FinishTime { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastUpdateTime { get; set; }
    }
}
