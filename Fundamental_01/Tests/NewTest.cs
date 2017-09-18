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
    }
}
