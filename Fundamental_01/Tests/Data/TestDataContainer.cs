
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Runtime.Serialization;



namespace Tests.Data
{
    public class TestDataContainer
    {

        private List<TestData> lista;

        

        public string SerializeTestList(string build)
        {
            string json = null;
            return json = new JavaScriptSerializer().Serialize(lista).ToString();
        }


        public List<TestData> Deserialization(string json)
        {
            lista = new JavaScriptSerializer().Deserialize<List<TestData>>(json);
            return lista;
        }


        public TestDataContainer()
        {
            if (lista == null)
            {
                lista = new List<TestData>();
            }
        }

        public void AddNewTestData(TestData data)
        {
            lista.Add(data);
        }

        public void UpdateTestData(string name, string value)
        {
            foreach (var item in lista)
            {
                if (item.Name.Equals(name))
                {
                    item.Value = value;
                }
            }
        }

        public void DeleteTestData(string name)
        {
            foreach (var item in lista)
            {
                if (item.Name.Equals(name))
                {
                    lista.Remove(item);
                }
            }
        }

        public List<TestData> Lista
        {
            get
            {
                return lista;
            }

            set
            {
                lista = value;
            }
        }
    }
}
