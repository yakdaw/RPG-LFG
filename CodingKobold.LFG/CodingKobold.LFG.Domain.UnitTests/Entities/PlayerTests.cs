using CodingKobold.LFG.Domain.Entities;
using NUnit.Framework;

namespace CodingKobold.LFG.Domain.UnitTests.Entities
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void MethodName_StateUnderTest_ExpectedBehavior()
        {
            // Arrange and Act
            var player = new Player("Example");

            // Assert
            Assert.AreEqual("Example", player.Nickname);
        }
    }
}