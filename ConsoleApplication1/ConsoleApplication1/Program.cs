using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        // input: float x
        // output: int a that is smallest but not smaller than x
        // idea: a = (int) x then a = a+1
        // idea: if x is negative then a is unchanged
        public static int Ceil(float x)
        {
            int a = (int)x;
            if (x > 0)
                if (x > a) 
                    a = a + 1;
            return a;
        }
        // input: float x
        // output: int a that is largest but not bigger than x
        // idea: a= (int)x 
        // if x negative then a=a-1
        // if x = a then a is unchanged
        public static int Floor(float x)
        {
            int a = (int)x;
            if (x < 0)
                if (x != a)
                    a = a - 1;
            return a;
        }
    }
}
