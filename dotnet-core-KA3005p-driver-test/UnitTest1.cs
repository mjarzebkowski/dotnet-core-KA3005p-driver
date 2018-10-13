using NUnit.Framework;
using dotnet_core_KA3005p_driver;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(30)]
        public void TestVoltage(int value){
            dotnet_core_KA3005p_driver.
        }
    }
}