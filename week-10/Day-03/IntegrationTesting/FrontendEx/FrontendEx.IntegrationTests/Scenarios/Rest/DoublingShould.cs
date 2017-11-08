using FrontendEx.IntegrationTests.TestFixtures;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace RestTest
{
    [Collection("BaseCollection")]
    public class DoublingShould
    {
        private TestContext Context;

        public DoublingShould(TestContext context)
        {
            //arrange
            Context = context;
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            //act
            var response = await Context.Client.GetAsync("/doubling?input=5");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Return()
        {
            //act
            var response = await Context.Client.GetAsync("/doubling?input=5");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnErrorMessage()
        {
            //act
            var response = await Context.Client.GetAsync("/doubling");
            string responseJson = await response.Content.ReadAsStringAsync();

            //assert
            Assert.Equal("{\"error\":\"Please provide an input!\"}", responseJson);
        }
    }
}