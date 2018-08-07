using System;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace consoleAppTests
{
    [TestClass]
    public class IUserProviderTest
    {
        [TestMethod]
        public void TestGetUsers()
        {
            var mockDataProvider = new Mock<consoleApp.IUserProvider>(MockBehavior.Strict);
            mockDataProvider.Setup(x => x.GetUsers()).Returns()
        }
    }
}
