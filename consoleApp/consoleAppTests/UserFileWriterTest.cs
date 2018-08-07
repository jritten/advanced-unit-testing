using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace consoleAppTests
{
    [TestClass]
    public class UserFileWriterTest
    {
        public static TestContext TestContext { get; set; }
        [TestMethod]
        [DeploymentItem("TestFile.txt")]
        public void TestMethod1()
        {
            var directory = TestContext.DeploymentDirectory;
            var pathToFile = Path.Combine(directory, "TestFile.txt");

            var content = File.ReadAllText(pathToFile);
            Assert.AreEqual("This is a test", content);

        
        }
    }
}
