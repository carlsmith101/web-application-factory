using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;


namespace SimpleApi.SimpleApiTests
{
    public class HelloWorldTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public HelloWorldTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetRequest_ReturnsHelloWorld()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/helloworld");
            response.EnsureSuccessStatusCode();

            // Assert
            var content = await response.Content.ReadAsStringAsync();
            Assert.Equal("Hello, World!", content);
        }
    }
}

