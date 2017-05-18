using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public partial class AmazonShop : BaseEntity
    {
        public int AmazonHostId { get; set; }

        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string ShopId { get; set; }


        public virtual AmazonHost AmazonHost { get; set; }

        public virtual Customer Customer { get; set; }


        public bool Deleted { get; set; }

        public bool IsSystem { get; set; }
    }
}
