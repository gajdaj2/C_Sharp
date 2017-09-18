using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Data;

namespace Tests
{
    [TestFixture]
    public class NewTest
    {

        public TestDataContainer data;
        public string sut;

        [SetUp]
        public void SetUp()
        {
            TestData data1 = new TestData();
            TestData data2 = new TestData();

            data1.Name = "SureName";
            data1.Value = "Gajda";

            data2.Name = "FirstName";
            data2.Value = "Jakub";

            data = new TestDataContainer();
            data.AddNewTestData(data1);
            data.AddNewTestData(data2);
            
        }

        [Test]
        public void ShouldBeSureNameGajda()
        {
            Assert.AreEqual("Gajda", data.Lista[0]);
        }

        [Test]
        public void ShoudBeFirstNameJakub()
        {
            Assert.AreEqual("Jakub", data.Lista[1]);
        }

        [Test,Order(1)]
        [Category("Json")]
       
        public void AShouldBSeralization()
        {
            sut = data.SerializeTestList("1111");
            Console.WriteLine(sut);
        }

        [Test,Order(2)]
        [Category("Json")]
        public void VShouldBDeseralization()
        {
            List<TestData> sutt = data.Deserialization(sut);
            foreach (var item in sutt)
            {
                Console.WriteLine(item.Name+" "+item.Value);
            } 
        }
    }
}
