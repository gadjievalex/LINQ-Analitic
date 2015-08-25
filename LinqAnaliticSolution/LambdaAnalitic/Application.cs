using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAnalitic
{
    public class Application
    {
        public static bool IsOdd(int i)
        {
            return ((i & 1) == 1);
        }
    }
}
