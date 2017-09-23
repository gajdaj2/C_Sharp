using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MicroOrmDemo.DataLayer.Dapper
{
    public class ContactRepository : IContactRepository
    {


        private IDbConnection db = new SqlConnection(@"Data Source=ANNA\SQLEXPRESS;Initial Catalog=ContactsDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Contact Add(Contact contact)
        {
            var sql =
                "INSERT INTO Contacts(FirstName,LastName,Email,Company,Title) VALUES(@FirstName,@LastName,@Email,@Company,@Title)" +
                 "SELECT CAST(SCOPE_IDENTITY() as int)";
            var id = this.db.Query<int>(sql, contact).Single();
            contact.Id = id;
            return contact;
        }

        public IContactRepository Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            return this.db.Query<Contact>("select * from Contacts").ToList();
        }

        public Contact GetFullContact(int id)
        {
            return this.db.Query<Contact>("select 8 from Contacts where Id=@Id",new {Id=id}).SingleOrDefault();
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
