using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public partial class ProductReviewAddHelpful : BaseEntity    
    {

        public int ProductId { get; set; }

        public string ReviewAuthorName { get; set; }

        public string ReviewDate { get; set; }

        public string ReviewStar { get; set; }

        public string ReviewTitle { get; set; }

        public string ReviewContent { get; set; }

        public string ReviewUrl { get; set; }

        public string TaskId { get; set; }

        public int Helpful { get; set; }

        public int TotalAddHelpful { get; set; }

        public int CurrentAddHelpful { get; set; }

        public bool Finished { get; set; }

        public bool Topped { get; set; }

        public bool ReturnRewardPointed { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime FinishTime { get; set; }

        public DateTime LastUpdateTime { get; set; }


        public virtual AmazonProduct Product { get; set; }



    }
}
