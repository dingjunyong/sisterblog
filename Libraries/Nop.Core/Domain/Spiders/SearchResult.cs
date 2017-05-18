using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public class SearchResult : BaseEntity
    {
        public string key { get; set; }

        public int page { get; set; }

        public string name { get; set; }

        public string vendor { get; set; }

        public string asin { get; set; }

        public int index { get; set; }

        public int exclude_sponsor_index { get; set; }

        public bool sponsored { get; set; }

        public string url { get; set; }

        public string price { get; set; }

        public DateTime search_time { get; set; }

        public string host { get; set; }
    }
}
