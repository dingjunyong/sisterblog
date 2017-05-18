using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public class HotNewRelease :  BaseEntity
    {
        public string asin { get; set; }

        public string url { get; set; }

        public string name { get; set; }

        public string price { get; set; }

        public int index { get; set; }

        public string category { get; set; }

        public string product_category { get; set; }

        public string picture { get; set; }

        public DateTime access_time { get; set; }

        public string host { get; set; }
    }
}
