using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challanges.Challenges
{
    public class Temperature
    {

        public void FindMaxMinTemp(double [] tempArray)
        {
            Console.WriteLine("Minumum Temp:"+tempArray.Min());
            Console.WriteLine("Maximum Temp:"+tempArray.Max());
        }
    }
}
