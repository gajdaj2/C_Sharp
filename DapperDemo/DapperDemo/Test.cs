using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestMethod()
        {
            IContactRepository repo = CreateRepository();
            var contact = repo.GetAll();
            
        }

        private IContactRepository CreateRepository()
        {
            return new Dapper.ContactRepository();
        }
    }
}
