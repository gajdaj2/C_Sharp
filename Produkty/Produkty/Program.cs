using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkty
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<ProductBase>().To<ProductA>();
            kernel.Bind<Create>().To<OdataTest>();

            var a = kernel.Get<ProductBase>();
            a.Id = "1";
            a.Name = "Kuba";
            Console.WriteLine(a.Name + " was created.");
            Console.ReadLine();


            //            kernel.Bind<Create>().To<ProductA>();
            //            kernel.Bind<Update>().To<ProductA>();
            /*
                        

                        var input = kernel.Get<Create>();
                        var update = kernel.Get<Update>();
                        input.Create(a);
                        update.Update(a);



                        Console.WriteLine("Method");
                        IKernel kernel2 = new StandardKernel();

                        kernel2.Bind<Create>().To<ProductB>();
                        var create = kernel2.Get<Create>();
            */

            

            Console.WriteLine("Create in Channel");
            var odata = kernel.Get<Create>();
            odata.Create(a);

            Console.ReadLine();

        }
    }
}
