using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataJSonOrm.DataModel;
using TestDataJSonOrm.Examples;
using TestDataJSonOrm.IModel;
using TestDataJSonOrm.TestDataRepository;
using System.Web;
using System.Web.Script.Serialization;

namespace TestDataJSonOrm
{
    [TestFixture]
    public class TestDataJSonOrm
    {
        [Test]
        [Category("Dapper")]
        public void ShouldAddNewTestData()
        {
            Validation v1 = new Validation();
            Validation v2 = new Validation();
            Validation v3 = new Validation();
            Validation v4 = new Validation();
            v1.Name = "Dupa1";
            v1.Value = "Jest Dupa";
            v2.Name = "Dupa2";
            v2.Value = "Jest Dupa";
            v3.Name = "Dupa3";
            v3.Value = "Jest Dupa";
            v4.Name = "Dupa4";
            v4.Value = "Jest Dupa";
            List<Validation> list = new List<Validation>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            var json = new JavaScriptSerializer().Serialize(list);

            TestDataOperation repo = CreateNewTestDataOperation();
            TestData dataa = new TestData();
            dataa.Build_Id = 11111;
            dataa.Test_Data = json;
            dataa.Team = "Phoenix";
            repo.Add(dataa);
        }

        [Test]
        [Category("Dapper")]
        public void ShouldGetTestDataJson()
        {
            TestDataOperation repo = CreateNewTestDataOperation();
            TestData json = repo.Find(11111);
            var lista = new JavaScriptSerializer().Deserialize<List<Validation>>(json.Test_Data);
            foreach (var item in lista)
            {
                Console.WriteLine(item.Name+":"+item.Value);
            }
        }

        private TestDataOperation CreateNewTestDataOperation()
        {
            return new TestDataRepository.TestDataOperation();
        }
    }
}
