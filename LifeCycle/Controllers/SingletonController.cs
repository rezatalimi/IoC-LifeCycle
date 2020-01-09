using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using TestDependencyInjectionAspCore.Class.Contract;

namespace TestDependencyInjectionAspCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Singleton")]
    public class SingletonController : BaseController
    {
        public SingletonController(IServiceProvider serviceProvider):base(serviceProvider)
        {
        }

        [HttpGet("CallMe")]
        public string CallMe()
        {
            var singleton = (ISingleton)serviceProvider.GetService(typeof(ISingleton));

            StringBuilder result = new StringBuilder();

            result.Append(Title + " CallMe");

            result.Append(Environment.NewLine);

            result.Append(GetLine() + singleton.GetMessage());

            result.Append(Environment.NewLine);

            singleton = (ISingleton)serviceProvider.GetService(typeof(ISingleton));

            result.Append(GetLine() + singleton.GetMessage());

            result.Append(Environment.NewLine);

            return result.ToStringForClient();
        }

        [HttpGet("CallMeAgain")]
        public string CallMeAgain()
        {
            var singleton = (ISingleton)serviceProvider.GetService(typeof(ISingleton));

            StringBuilder result = new StringBuilder();

            result.Append(Title + " CallMeAgain");

            result.Append(Environment.NewLine);

            result.Append(GetLine() + singleton.GetMessage());

            result.Append(Environment.NewLine);

            singleton = (ISingleton)serviceProvider.GetService(typeof(ISingleton));

            result.Append(GetLine() + singleton.GetMessage());

            result.Append(Environment.NewLine);

            return result.ToStringForClient();
        }
    }
}