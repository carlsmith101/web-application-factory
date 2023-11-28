using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace SimpleApiTests
{
	public class CustomWebApplicationFactory<Startup> : WebApplicationFactory<Startup> where Startup : class
	{
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(builder =>
            {
                // add in custom config here
                builder.Build();
            });
        }
    }
}

