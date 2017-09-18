
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Runtime.Serialization.;


namespace Tests.Data
{
    public class TestDataContainer
    {

        private List<TestData> lista;

        

        public void SerializeTestList(string name)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Lista));        
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
