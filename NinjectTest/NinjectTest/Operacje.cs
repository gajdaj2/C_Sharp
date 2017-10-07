using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    public interface Operacje
    {
        void Add(Person a);
        void Update(string id);
        void Delete(string id);
        List<Person> GetAll();
    }
}
