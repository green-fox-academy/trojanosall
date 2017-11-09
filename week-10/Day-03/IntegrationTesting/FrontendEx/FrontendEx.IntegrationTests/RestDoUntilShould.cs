using FrontendEx.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FrontendEx.IntegrationTests
{
    public class RestDoUntilShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestDoUntilShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("/dountil");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnWithOutWhat()
        {
            var myDoUntilClass = new DoUntilClass();

            var convertedUsedUntil = JsonConvert.SerializeObject(usedUntil);
            var data = new StringContent(convertedUsedUntil.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await Client.PostAsync("dountil", data);

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
