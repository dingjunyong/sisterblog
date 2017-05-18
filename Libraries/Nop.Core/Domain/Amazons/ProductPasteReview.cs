using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public partial class ProductPasteReview : BaseEntity
    {
        public int ProductId { get; set; }

        public int TaskId { get; set; }

        public string Title { get; set; }

        public int Star { get; set; }

        public string Content { get; set; }

        public DateTime PasteDate { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual AmazonProduct  Product { get; set; }
    }
}
