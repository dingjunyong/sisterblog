using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public class ProductKeywordMonitor : BaseEntity
    {
        public int ProductId { get; set; }

        public string Keyword { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime FinishTime { get; set; }

        public DateTime LastUpdateTime { get; set; }


        public bool IsNofity { get; set; }

        public int UpNumberRange { get; set; }

        public int UpNumber { get; set; }

        public int DownNumberRange { get; set; }

        public int DownNumber { get; set; }


        public virtual AmazonProduct Product { get; set; }
    }
}
