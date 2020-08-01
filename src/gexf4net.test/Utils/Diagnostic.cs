using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gexf4net.test.Utils
{
    class Diagnostic
    {
        public static void Compare(string expected, string actual)
        {
            char[] e = expected.ToCharArray();
            char[] a = actual.ToCharArray();

            int l = Math.Min(e.Length, a.Length);

            for (int i = 0; i < l; i++)
            {
                if (e[i] != a[i])
                {
                    Console.WriteLine("First diff at {0}:  expected={1} actua={2}", i, e[i], a[i]);
                }
            }
        }
    }
}
