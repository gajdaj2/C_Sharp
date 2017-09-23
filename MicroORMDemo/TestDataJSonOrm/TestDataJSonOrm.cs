using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataJSonOrm.DataModel;
using TestDataJSonOrm.IModel;
using TestDataJSonOrm.TestDataRepository;

namespace TestDataJSonOrm
{
    [TestFixture]
    public class TestDataJSonOrm
    {
        [Test]
        public void ShouldAddNewTestData()
        {
            TestDataOperation repo = CreateNewTestDataOperation();
            TestData dataa = new TestData();
            dataa.Build_Id = 111;
            dataa.Test_Data = "1312312312312312";
            dataa.Team = "Phoenix";
            repo.Add(dataa);
        }


        private TestDataOperation CreateNewTestDataOperation()
        {
            return new TestDataRepository.TestDataOperation();
        }
    }
}
