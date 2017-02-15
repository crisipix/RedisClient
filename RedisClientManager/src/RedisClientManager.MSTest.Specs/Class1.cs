using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisClientManager.MSTest.Specs
{
    /// <summary>
    /// https://blogs.msdn.microsoft.com/visualstudioalm/2016/05/30/announcing-mstest-framework-support-for-net-core-rc2-asp-net-core-rc2/
    /// 
    /// http://dotnetthoughts.net/unit-test-aspnet-core-applications-with-mstest/
    /// https://weblogs.asp.net/ricardoperes/unit-testing-net-core
    /// </summary>
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestMethodPassing()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestMethodFailing()
        {
            Assert.IsTrue(false);
        }
    }
}
