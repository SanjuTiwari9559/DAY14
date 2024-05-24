using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace delegateAndLamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Arthimatic arthimatic = new Arthimatic();
            arithmatic arithmatic1 = (a,b)=>Console.WriteLine($"{a+b}");
        


            //  arithmatic1(2, 3);
            //arithmatic1 += arthimatic.remove;
            arithmatic1(3, 4);
        }
        public delegate void arithmatic(int x, int y);  
      public   class Arthimatic
        {
            public void add(int x, int y) {
                Console.WriteLine("This is add method");

            }
            public void remove(int x, int y)
            {
                Console.WriteLine("This is Remove method");
            }
           
        }
    }
}
