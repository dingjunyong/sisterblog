using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public class AmazonProductReviewToTopCustomerMapping : BaseEntity
    {
        public int CustomerId { get; set; }

        public string Host { get; set; }

        public string ShopId { get; set; }

        public string Asin { get; set; }

        public string ReviewAuthorName { get; set; }

        public string ReviewDate { get; set; }

        public string ReviewStar { get; set; }

        public string ReviewTitle { get; set; }

        public string ReviewContent { get; set; }

        public string ReviewUrl { get; set; }

        public int BrushTaskId { get; set; }

        public int Helpful { get; set; }

        public int AddHelpful { get; set; }

        public bool IsFinished { get; set; }

        public int FinishHelpful { get; set; }

        public bool IsToped { get; set; }

        public bool IsReturnRewardPointed { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime FinishTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
