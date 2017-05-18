using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public class AmazonQuantityProductGroup
    {
        public int MinId { get; set; }

        public string Title { get; set; }

        public int TotalQuantity { get; set; }

        public int AsinCount { get; set; }
    }
}
