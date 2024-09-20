using Bank.WebApi.Models;
using NUnit.Framework;
using NUnitAssert = NUnit.Framework.Assert;
using MSTestAssert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Bank.WebApi.Tests
{
    [TestFixture]
    public class BanckAccountTests
    {
        [Test]
        public void TestMethod()
        {
            // Usa NUnitAssert o MSTestAssert según sea necesario
            NUnitAssert.AreEqual(1, 1);
            // MSTestAssert.AreEqual(1, 1); // Si necesitas usar MSTest
        }
    }
}