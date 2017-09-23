using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace MicroOrmDemo.DataLayer.Tests
{
    /// <summary>
    /// Summary description for Tests
    /// </summary>
    [TestClass]
    public class Tests
    {
        public Tests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion



        [TestMethod]
        public void ShouldDeleteContact()
        {
            IContactRepository repo = CreateContactRepository();
            repo.Remove(9);
        }
        [TestMethod]
        public void ShouldUpdateContact()
        {
            IContactRepository repo = CreateContactRepository();
            var contact = repo.Find(1);
            contact.FirstName = "jakub222";
            repo.Update(contact);
            IContactRepository repo2 = CreateContactRepository();
            var con = repo2.Find(1);
            con.FirstName.Should().Be("jakub222");
            
        }


        [TestMethod]
        public void ShouldGetOneContact()
        {
            IContactRepository repo = CreateContactRepository();
            var contact = repo.GetFullContact(1);
            contact.ShouldHave<Contact>();
        }
        [TestMethod]
        public void ShouldGetAllContacts()
        {
            IContactRepository repo = CreateContactRepository();
            var contacts = repo.GetAll();
            contacts.Should().NotBeNull();
            contacts.Count.Should().Be(8);
        }

        [TestMethod]
        public void ShouldAddNewContact()
        {
            IContactRepository repo = CreateContactRepository();
            Contact cont = new Contact
            {
                FirstName = "Jan",
                LastName = "Kaleciak",
                Company = "GE",
                email = "jan.kaleciak@ge.com",
                Title = "Mr."
            };
            repo.Add(cont);
        }



        private IContactRepository CreateContactRepository()
        {
            return new Dapper.ContactRepository();
        }
    }

    
}
