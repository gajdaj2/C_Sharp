using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public class Filozofia : Operacje
    {
        public List<Person> lista = new List<Person>();
        public void Add(Person a)
        {
            lista.Add(a);
        }

        public Filozofia()
        {

        }

        [Inject]
        public Filozofia(string a)
        {
            Console.WriteLine("Hello Filozofia "+a);
        }


        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return lista; 
        }

        public void Update(string id)
        {
            throw new NotImplementedException();
        }
    }
}
