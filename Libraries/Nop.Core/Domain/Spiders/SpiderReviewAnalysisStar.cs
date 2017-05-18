using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public class SpiderReviewStar
    {

        public string asin { get; set; }

        public string host { get; set; }

        public Byte VerifiedPurchase { get; set; }

        public int star { get; set; }

        public int starnum { get; set; }
    }
}
