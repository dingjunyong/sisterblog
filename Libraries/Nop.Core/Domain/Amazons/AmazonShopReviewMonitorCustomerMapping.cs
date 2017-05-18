using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public partial class AmazonShopReviewMonitorCustomerMapping : BaseEntity
    {
        public int CustomerId { get; set; }

        public string Host { get; set; }

        public string HostName { get; set; }

        public string ShopId { get; set; }

        public string ShopName { get; set; }

        public int ShopReviewTaskId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime FinishTime { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
