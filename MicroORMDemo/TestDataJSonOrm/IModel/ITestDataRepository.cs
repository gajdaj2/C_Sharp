using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataJSonOrm.DataModel;

namespace TestDataJSonOrm.IModel
{
    public interface ITestDataRepository
    {
        TestData Add(TestData data);
        TestData GetAll();
        TestData Update(int build_id);
        TestData Remove(int build_id);
        TestData Find(int build_id);
    }
}
