using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public class AmazonBrowseProduct : BaseEntity
    {
        public int AmazonProductId { get; set; }
        
        public virtual AmazonProduct AmazonProduct { get; set; }
    }
}
