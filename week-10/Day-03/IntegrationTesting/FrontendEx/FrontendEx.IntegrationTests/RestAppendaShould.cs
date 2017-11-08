//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.TestHost;
//using System;
//using System.Collections.Generic;
//using System.Net;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace FrontendEx.IntegrationTests
//{
//    class RestAppendaShould
//    {
//        private readonly TestServer Server;
//        private readonly HttpClient Client;

//        public RestAppendaShould()
//        {
//            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
//            Client = Server.CreateClient();
//        }

//        [Fact]
//        public async Task ReturnOkStatus()
//        {
//            var response = await Client.GetAsync("/greeter");

//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//        }

//        [Fact]
//        public async Task ReturnErrorMessage()
//        {
//            //act
//            var response = await Client.GetAsync("/greeter");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            //assert
//            Assert.Equal("{\"error\":\"Please provide a name!\"}", responseJson);
//        }

//        [Fact]
//        public async Task ReturnWithContent()
//        {
//            //act
//            var response = await Client.GetAsync("/greeter?name=Petike&title=student");
//            string responseJson = await response.Content.ReadAsStringAsync();

//            //assert
//            Assert.Equal("{\"welcome_message\":\"Oh, hi there Petike, my dear student!\"}", responseJson);
//        }

//    }
//}