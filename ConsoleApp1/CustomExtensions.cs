using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class CustomExtensions
    {
        public static IOrderedEnumerable<string> getSorted(this List<string> lstr)
        {
            return lstr.OrderBy(s => s.Substring(s.LastIndexOf(" ")));
        }
    }
}
