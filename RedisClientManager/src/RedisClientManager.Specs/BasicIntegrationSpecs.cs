using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace RedisClientManager.Specs
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/core/testing/integration-testing
    /// https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing
    /// </summary>
    public class BasicIntegrationSpecs
    {
        [Fact]
        public void TestMain()
        {
            var result = RedisClientManager.Program.Process();
            Assert.Equal("Your Value is Core1.0_abcdefg", result);

        }
    }
}
