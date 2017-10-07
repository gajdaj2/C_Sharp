using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;


namespace MoqTest
{
    [TestFixture]
    public class TestClass
    {

        private Mock<IOperation> moc;
        private string name;
        private Mock<Customer> cust;

        [SetUp]
        public void SetUp()
        {
            var service = Mock.Of<IServiceProvider>
            moc = new Mock<IOperation>();
            moc.Setup(o => o.GetAccount(new Customer() { name = "Kuba" })).Returns(1.11f);
            cust = new Mock<Customer>();
            cust.Setup(c => c.PerformOperation(new Customer { name = "Jakub" }));
        }
        [Test]
        public void TestMethod()
        {


                
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
    }
}
