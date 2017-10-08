using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkty
{
    public class ProductA:ProductBase,Create,Update
    {
        public ProductA()
        {
            Console.WriteLine("Product A");
        }


       
        public void Create(ProductBase a)
        {
            Console.WriteLine(a.Name+" Created new");
        }

        public void Update(ProductBase a)
        {
            Console.WriteLine(a.Name + " Update");
        }
    }
}
