using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Class1_Initialize()
        {
            // Arrange
            const string expectedValue = Class1.DEFAULT_VALUE;
            var instance = new Class1();

            // Act
            instance.Initialize();
            string actualValue = instance.Property1;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}