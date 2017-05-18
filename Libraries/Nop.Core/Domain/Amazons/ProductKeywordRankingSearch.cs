using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public class ProductKeywordRankingSearch : BaseEntity
    {
        public int ProductId { get; set; }

        public string Keyword { get; set; }

        public virtual AmazonProduct Product { get; set; }
    }
}
