using Challanges.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challanges
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] a = new string[] { "1", "2", "3","", "4", "5", "6", "7","8", "9", "10" };
            ArrayRevert arr = new ArrayRevert();

            arr.Reverse(a);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
