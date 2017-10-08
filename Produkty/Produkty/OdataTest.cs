using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkty
{
    public class OdataTest : Create
    {

       
        public void Create(ProductBase a)
        {
            Console.WriteLine("Prouct Test Create "+a.Name);
        }
    }
}
