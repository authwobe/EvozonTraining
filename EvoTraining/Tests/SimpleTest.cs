
using System.Threading;
using EvoTraining.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvoTraining.Tests
{
    [TestClass]
    public class SimpleTest
    {
        public static SimplePage SimplePage;

        [TestInitialize]
        public void Before()
        {
            Browser.CreateNew();
        }


        [TestMethod]
        public void OpenTestUrl()
        {
            SimplePage.Navigate("http://www.gooogl.com");
            Thread.Sleep(5000);
        }

        [TestCleanup]
        public void After()
        {
            Browser.Close();
        }
    }
}
