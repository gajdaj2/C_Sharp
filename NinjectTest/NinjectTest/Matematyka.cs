using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public class Matematyka : Operacje
    {
        public List<Person> list = new List<Person>();


        public Matematyka()
        {

        }

        [Inject]
        public Matematyka(string a)
        {
            Console.WriteLine("Hello matermatyka"+a);
        }

        public void Add(Person a)
        {
            list.Add(a);
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return list;
        }

        public void Update(string id)
        {
            throw new NotImplementedException();
        }
    }
}
