using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IContactRepository repo = CreateRepository();
            var contact = repo.GetAll();
            Console.WriteLine(contact.ToString());
            Console.ReadLine();

        }


        private static IContactRepository CreateRepository()
        {
            return new Dapper.ContactRepository();
        }

    }
}
