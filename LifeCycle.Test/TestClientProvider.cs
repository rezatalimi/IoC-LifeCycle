using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using TestDependencyInjectionAspCore;

namespace XUnitTestDependencyInjectionAspCore
{
    public class TestClientProvider : IDisposable
    {
        private TestServer testServer { get; set; }

        public HttpClient Client { get; private set; }

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }

        public void Dispose()
        {
            testServer?.Dispose();

            Client?.Dispose();
        }
    }
}
