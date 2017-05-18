using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Autos
{
    public class PasteQuestion : BaseEntity
    {
        public string asin { get; set; }

        public string host { get; set; }

        public string question { get; set; }

        public DateTime paste_date { get; set; }

        public DateTime created { get; set; }

        public bool isfinished { get; set; }
    }
}
