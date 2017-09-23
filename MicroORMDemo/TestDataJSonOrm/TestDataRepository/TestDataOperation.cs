using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TestDataJSonOrm.DataModel;
using TestDataJSonOrm.IModel;
using System.Data;
using System.Data.SqlClient;

namespace TestDataJSonOrm.TestDataRepository
{
    public class TestDataOperation : ITestDataRepository
    {

        private IDbConnection db = new SqlConnection(@"Data Source=ANNA\SQLEXPRESS;Initial Catalog=TEST_DATA;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public TestData Add(TestData data)
        {
            var sql = "INSERT INTO TESTDATA(Build_Id,Test_Data,Team) VALUES(@Build_Id,@Test_Data,@Team)" +
                 "SELECT CAST(SCOPE_IDENTITY() as int)";
            var id = this.db.Query<int>(sql, data).Single();
            data.Id = id;
            return data;
        }

        public TestData Find(int build_id)
        {
            var sqlFind = "select * from TESTDATA WHERE Build_Id=@Build_Id";
            return this.db.Query<TestData>(sqlFind, new { Build_id = build_id }).SingleOrDefault();
        }

        public TestData GetAll()
        {
            throw new NotImplementedException();
        }

        public TestData Remove(int build_id)
        {
            throw new NotImplementedException();
        }

        public TestData Update(int build_id)
        {
            throw new NotImplementedException();
        }
    }
}
