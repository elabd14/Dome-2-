using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome2
{
    internal class CompaerFunction
    {
        public static bool ComaperGrt(int x , int y)
        {
            return x>y;
        }
        public static bool ComaperLess(int x, int y)
            {
            return x<y;
            }

        internal bool Invoke(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
