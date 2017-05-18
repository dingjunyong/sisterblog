using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public partial class AmazonHost : BaseEntity
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string IconUrl { get; set; }

        public float TimeDifference { get; set; }
    }
}
