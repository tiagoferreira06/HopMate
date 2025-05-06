using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace hopmate.Tests
{
    [TestClass]
    public class ColorsIntegrationTests
    {
        private static HttpClient _client;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            var factory = new WebApplicationFactory<Program>();
            _client = factory.CreateClient();
        }

        [TestMethod]
        public async Task GetColors_ReturnsOk()
        {
            var response = await _client.GetAsync("/api/colors");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
