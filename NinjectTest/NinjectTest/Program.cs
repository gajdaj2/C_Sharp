using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<Operacje>().To<Matematyka>().WithConstructorArgument("a","Kuba");
            var operacje2 = kernel.Get<Operacje>();

            Console.ReadLine();
            //Inject constructor
            var uzywa = kernel.Get<UzywaOperacja>();
            uzywa.Dodaj(new Person() { Id = "1" });
            uzywa.Dodaj(new Person() { Id = "2" });
            uzywa.Dodaj(new Person() { Id = "3" });
            uzywa.GetAll();
            Console.ReadLine();


            //Inject propety
            var uzywa2 = kernel.Get<UzywaOperacja2>();
            uzywa2.Dodaj(new Person() { Id = "21" });
            uzywa2.Dodaj(new Person() { Id = "22" });
            uzywa2.Dodaj(new Person() { Id = "23" });
            uzywa2.GetAll();


            Console.ReadLine();

            //Inject contructor
            var uzywa3 = new UzywaOperacja2(kernel.Get<Operacje>());
            uzywa3.Dodaj(new Person() { Id = "31" });
            uzywa3.Dodaj(new Person() { Id = "32" });
            uzywa3.Dodaj(new Person() { Id = "33" });
            uzywa3.GetAll();


            Console.ReadLine();


            //Inject Method
            var uzywa4 = kernel.Get<UzywaOperacja3>();
            uzywa4.Dodaj(new Person() { Id = "41" });
            uzywa4.Dodaj(new Person() { Id = "42" });
            uzywa4.Dodaj(new Person() { Id = "43" });
            uzywa4.GetAll();
        }
    }
}
