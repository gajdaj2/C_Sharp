﻿using Ninject;
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
            kernel.Bind<Create>().To<ProductA>();
            kernel.Bind<Update>().To<ProductA>();

            var a = kernel.Get<ProductBase>();
            a.Id = "1";
            a.Name = "Kuba";
            Console.WriteLine(a.Name+" was created.");
            Console.ReadLine();

            var input = kernel.Get<Create>();
            var update = kernel.Get<Update>();
            input.Create(a);
            update.Update(a);


            Console.ReadLine();

        }
    }
}
