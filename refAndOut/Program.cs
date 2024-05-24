using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            //int a = 15;
           // int b = 12;
           // sum(ref a, ref b);
            //Console.WriteLine(a + " " + b);
            sumOut(out a, out b);
            Console.WriteLine(a + " " + b);
        }
        public static void sum(ref int a, ref int b)
        {
            a=a+b;  

        }
        public static void  sumOut(out  int a, out int b)
        {
            a = 10;
            b=12;
            a = a + b;
        }
    }
}
