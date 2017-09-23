using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration.Assemblies;
using System.Data.SqlClient;

namespace DapperDemo.Dapper
{
    public class ContactRepository : IContactRepository
    {

        private IDbConnection db = new SqlConnection(@"Data Source=D:\Repos\C_S\C_Sharp\DapperDemo\Test2.sqlite;Password=kondor");

        public Contact Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            
            var ret =  db.Query<Contact>("SELECT * FROM Contacts").ToList();
            return ret;
        }

        public Contact GetFullContact(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
