using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public class SpiderReviewStatistic
    {

        public string asin { get; set; }

        public string host { get; set; }

        public int star { get; set; }

        public int vp_num { get; set; }

        public int pt_num { get; set; }
    }
}
