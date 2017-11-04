using System;
using CodingKobold.LFG.Domain.Entities;
using NUnit.Framework;

namespace CodingKobold.LFG.Domain.UnitTests.Entities
{
    [TestFixture]
    public class LoginInfoTests
    {
        [Test]
        public void SetRegisterDate_Executed_SetsTodayDate()
        {
            // Arrange
            var loginInfo = new LoginInfo();

            // Act
            loginInfo.SetRegisterDate();

            // Assert
            Assert.AreEqual(DateTime.Now.Date, loginInfo.RegisterTime);
        }

        [Test]
        public void SetLogoutDate_Executed_SetsTodayDate()
        {
            // Arrange
            var loginInfo = new LoginInfo();

            // Act
            loginInfo.SetLogoutDate();

            // Assert
            Assert.AreEqual(DateTime.Now.Date, loginInfo.LastSeenTime);
        }
    }
}
