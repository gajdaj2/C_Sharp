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
            double[] temp = new double[] { 10,0,11,3,4,5,-2,0,3,6,-3,3, 0,0 };
            Temperature t = new Temperature();
            t.FindMaxMinTemp(temp);
            Console.ReadLine();
        }
    }
}
