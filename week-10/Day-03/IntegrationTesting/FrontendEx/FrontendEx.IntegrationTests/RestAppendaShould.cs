using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FrontendEx.IntegrationTests
{
    public class RestAppendaShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestAppendaShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("/appenda/{appendable}");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnWithContent()
        {
            //act
            var response = await Client.GetAsync("/appenda/kuty");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"appended\":\"kutya\"}", responseJson);
        }

        [Fact]
        public async Task ReturnNotFound()
        {
            //act
            var response = await Client.GetAsync("/appenda");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

    }
}