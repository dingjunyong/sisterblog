using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Autos
{
    public class PasteReview : BaseEntity
    {
        public string asin { get; set; }

        public string host { get; set; }

        public string title { get; set; }

        public int star { get; set; }

        public string content { get; set; }

        public DateTime paste_date { get; set; }

        public DateTime created { get; set; }

        public bool isfinished { get; set; }
    }
}
