using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            int[] arr2=new int[2];
            string[] arr = new string[5];
            arr[0] = null;
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
            foreach(int  i in arr2)
            {
                Console.WriteLine(i);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
