namespace CodingKobold.LFG.Domain.UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Class1
    {
        [Test]
        public void SimpleTest()
        {
            // Arrange
            var firstNumber = 4;
            var secondNumber = 5;

            // Act
            var additionResult = firstNumber + secondNumber;

            // Assert
            Assert.AreEqual(9, additionResult);
        }
    }
}
