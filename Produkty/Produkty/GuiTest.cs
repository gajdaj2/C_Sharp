using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkty
{
    public class GuiTest : Create, Update
    {
        
        public void Create(ProductBase a)
        {
            Console.WriteLine("GUI Test Create product"+a.Name);
        }

        public void Update(ProductBase a)
        {
            Console.WriteLine("GUI Test Update product" + a.Name);
        }
    }
}
