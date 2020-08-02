using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net.test.Utils
{
    public static class StringUtils
    {
        public static string StripByteOrderMark(this string input)
        {
            return input.Trim(new char[] { '\uFEFF' });
        }
    }
}
