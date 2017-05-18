using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Autos
{
    public class StockRecord
    {
        public string Asin { get; set; }
        public string Host { get; set; }
        public DateTime SearchDateTime { get; set; }
        public int Stock { get; set; }
    }
}
