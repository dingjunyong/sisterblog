using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public class AmazonBrowseTask : BaseEntity
    {
        public int AmazonBrowseProductId { get; set; }

        public int Times { get; set; }

        public DateTime Date { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }


        public virtual AmazonBrowseProduct AmazonBrowseProduct { get; set; }
    }
}
