using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public class AmazonCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ParentName { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }
    }
}
