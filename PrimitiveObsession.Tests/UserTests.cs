using PrimitiveObsession.Wrong;
using System;
using Xunit;

namespace PrimitiveObsession.Tests
{
    public class UserTests
    {
        private readonly User _sut;
        //private readonly Better.User _sut;

        public UserTests()
        {
            _sut = new User();
            //_sut = new Better.User();
        }
        [Fact]
        public void CreateUser_EmptyUsername_ThrowsArgumentException()
        {   
            Assert.Throws<ArgumentException>(() => _sut.CreateUser(string.Empty, string.Empty));
        }

        [Fact]
        public void CreateUser_EmptyPassword_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _sut.CreateUser("test", string.Empty));
        }

        [Fact]
        public void CreateUser_ShortPassword_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _sut.CreateUser("test", "123"));
        }

        [Fact]
        public void CreateUser_CorrectCalues_ReturnsTrue()
        {
            Assert.True(_sut.CreateUser("test", "12356789"));
        }
    }
}
