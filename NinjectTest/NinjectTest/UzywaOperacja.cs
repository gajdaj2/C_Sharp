using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public class UzywaOperacja
    {
        private Operacje Operacje { get; set; }


        
        public UzywaOperacja(Operacje a)
        {
            Operacje = a;
        }


        public void Dodaj(Person p)
        {
            Operacje.Add(p);
        }


        public void GetAll()
        {
            foreach (var item in Operacje.GetAll())
            {
                Console.WriteLine(item.Id);
            }
        }


    
    }
}
