using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public class AmazonQuantityProduct : BaseEntity
    {
        public string Asin { get; set; }

        public string Title { get; set; }

        public int Quantity { get; set; }

        public int HostId { get; set; }

        public int CustomerId { get; set; }

        public int DaySearchCount { get; set; }

        

        public string StockUrl { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }


        public virtual AmazonHost Host { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
