using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkty
{
    public class ProductB:ProductBase,Create
    {
        public ProductB()
        {
            Console.WriteLine("Product B");
        }

        public void Create(ProductBase a)
        {
            Console.WriteLine("Create "+a);
        }
    }
}
