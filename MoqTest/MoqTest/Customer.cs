using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTest
{
    public class Customer
    {
        public string name;
        IOperation operacje;

        public void PerformOperation(Customer c)
        {
            operacje.CreateAccount(c);
        }

    }
}
