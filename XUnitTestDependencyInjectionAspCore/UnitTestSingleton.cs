using System.Net;
using System.Net.Http;
using Xunit;

namespace XUnitTestDependencyInjectionAspCore
{
    public class UnitTestSingleton
    {
        [Fact]
        public async System.Threading.Tasks.Task Test_Singleton_CallMeAsync()
        {
            using (var client = new TestClientProvider().Client)
            {
                // act
                HttpResponseMessage respons = await client.GetAsync("api/Singleton/CallMe");

                var firstContents = await respons.Content.ReadAsStringAsync();

                respons = await client.GetAsync("api/Singleton/CallMeAgain");

                var secondContents = await respons.Content.ReadAsStringAsync();

                // assert
                Assert.Equal(HttpStatusCode.OK, respons.StatusCode);
            }
        }
    }
}
