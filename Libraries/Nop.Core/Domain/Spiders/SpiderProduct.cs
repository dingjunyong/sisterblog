using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public partial class SpiderProduct : BaseEntity
    {
        public string asin { get; set; }

        public string url { get; set; }

        public string name { get; set; }

        public string vendor { get; set; }

        public string vendor_url { get; set; }

        public string real_price { get; set; }

        public string saved { get; set; }

        public int saved_percent { get; set; }

        public string original_price { get; set; }

        public DateTime access_time { get; set; }

        public int product_id { get; set; }

        public int review_count { get; set; }

        public string review_star { get; set; }

        public int review_star1 { get; set; }

        public int review_star2 { get; set; }

        public int review_star3 { get; set; }

        public int review_star4 { get; set; }

        public int review_star5 { get; set; }

        public string host { get; set; }

        public string description { get; set; }

        public string long_description { get; set; }

        public string pictures { get; set; }

        public string bestseller_rank { get; set; }

        public string color { get; set; }

        public string dimension { get; set; }

        public string shipping_weight { get; set; }

        public string weight { get; set; }

        public string category { get; set; }


        #region 应该忽略的属性

        public string shop_id { get; set; }

        public string review_top_avg_star { get; set; }

        public DateTime last_date { get; set; }

        public string review_most_avg_star { get; set; }

        #endregion

    }
}
