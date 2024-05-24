using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamdaExpression2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmatic arithmatic = new Arithmatic();
            //This is Annonumes
            //operation operation = delegate (int a, int b)
            //{
            //       return a + b;
            //};
            //This is lamda Expression
            operation operation = (a, b) => a + b;
            operation += (a, b) => a - b;

        int sum=    operation(3, 4);

            Console.WriteLine(sum);

        }
        public delegate int operation(int x, int y);
        public class Arithmatic
        {
            //public int sum(int x ,int y)
            //{
            //    return x+y;
            //}
            public int sub(int x ,int y)
            {
                return (x - y);
            }
        }
    }
}
