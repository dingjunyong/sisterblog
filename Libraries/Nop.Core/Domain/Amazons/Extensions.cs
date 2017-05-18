using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.Amazons
{
    public static class Extensions
    {
        public static string GetStarNum(this double score)
        {
            
            if (score < 0.5)
            {
                return "0";
            }
            else if (score>=0.5 && score<1)
            {
                return "0.5";
            }
            else if (score >= 1 && score < 1.5)
            {
                return "1";
            }
            else if (score >= 1.5 && score < 2)
            {
                return "1.5";
            }
            else if (score >= 2 && score < 2.5)
            {
                return "2";
            }
            else if (score >= 2.5 && score < 3)
            {
                return "2.5";
            }
            else if (score >= 3 && score < 3.5)
            {
                return "3";
            }
            else if (score >= 3.5 && score < 4)
            {
                return "3.5";
            }
            else if (score >= 4 && score < 4.5)
            {
                return "4";
            }
            else if (score >= 4.5 && score < 5)
            {
                return "4.5";
            }
            else
            {
                return "5";
            }
        }
    }
}
