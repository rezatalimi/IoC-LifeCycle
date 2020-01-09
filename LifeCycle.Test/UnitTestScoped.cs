using System.Net;
using System.Net.Http;
using Xunit;

namespace XUnitTestDependencyInjectionAspCore
{
    public class UnitTestScoped
    {
        [Fact]
        public async System.Threading.Tasks.Task Test_Scoped_CallMeAsync()
        {
            using (var client = new TestClientProvider().Client)
            {
                // act
                HttpResponseMessage respons = await client.GetAsync("api/Scoped/CallMe");

                var firstContents = await respons.Content.ReadAsStringAsync();

                respons = await client.GetAsync("api/Scoped/CallMeAgain");

                var secondContents = await respons.Content.ReadAsStringAsync();

                // assert
                Assert.Equal(HttpStatusCode.OK, respons.StatusCode);
            }
        }
    }
}
