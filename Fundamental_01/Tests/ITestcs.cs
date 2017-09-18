using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    interface ITest
    {
        void Init();
        void Run(ITest test);
        void Assert();
    }
}
