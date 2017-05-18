using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Spiders
{
    public class SearchTask : BaseEntity
    {

        public string key0 { get; set; }

        public int page { get; set; }

        public int interval0 { get; set; }

        public string host { get; set; }

        public int status { get; set; }
    }
}
