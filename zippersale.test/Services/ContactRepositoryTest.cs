using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zippersale.ContextDB;
using zippersale.Models;
using zippersale.Repositories;

namespace zippersale.test.Services
{
    public class ContactRepositoryTest
    {
        private readonly AppDbContext _appDbContext;
        public ContactRepositoryTest(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [Fact]
        public void SaveContactMessage_ok()
        {
            //Arrange
            Mock<Contact> mockContact = new Mock<Contact>();
            ContactRepository contactRepository = new ContactRepository(_appDbContext);

            //Act
            var result = contactRepository.SaveContactMessage(mockContact.Object);

            //Assert
            Assert.True(result);

        }


        
        public void SaveContactMessage_fail()
        {
            //Arrange
            ContactRepository contactRepository = new ContactRepository(_appDbContext);
            Contact contact = null;

            //Act
            var result = contactRepository.SaveContactMessage(contact);

            //Assert
            Assert.False(result);

        }
    }

}

