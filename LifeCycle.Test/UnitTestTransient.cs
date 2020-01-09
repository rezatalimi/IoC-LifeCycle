using System.Net;
using System.Net.Http;
using Xunit;

namespace XUnitTestDependencyInjectionAspCore
{
    public class UnitTestTransient
    {
        [Fact]
        public async System.Threading.Tasks.Task Test_Transient_CallMeAsync()
        {
            using (var client = new TestClientProvider().Client)
            {
                // act
                HttpResponseMessage respons = await client.GetAsync("api/Transient/CallMe");

                var firstContents = await respons.Content.ReadAsStringAsync();

                respons = await client.GetAsync("api/Transient/CallMeAgain");

                var secondContents = await respons.Content.ReadAsStringAsync();

                // assert
                Assert.Equal(HttpStatusCode.OK, respons.StatusCode);
            }
        }
    }
}
