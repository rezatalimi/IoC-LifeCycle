using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using TestDependencyInjectionAspCore.Class.Contract;

namespace TestDependencyInjectionAspCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Transient")]
    public class TransientController : BaseController
    {
        public TransientController(IServiceProvider serviceProvider):base(serviceProvider)
        {
        }

        [HttpGet("CallMe")]
        public string CallMe()
        {
            var transient = (ITransient)serviceProvider.GetService(typeof(ITransient));

            StringBuilder result = new StringBuilder();

            result.Append(Title + " CallMe");

            result.Append(Environment.NewLine);

            result.Append(GetLine() + transient.GetMessage());

            result.Append(Environment.NewLine);

            transient = (ITransient)serviceProvider.GetService(typeof(ITransient));

            result.Append(GetLine() + transient.GetMessage());

            result.Append(Environment.NewLine);

            return result.ToStringForClient();
        }

        [HttpGet("CallMeAgain")]
        public string CallMeAgain()
        {
            var transient = (ITransient)serviceProvider.GetService(typeof(ITransient));

            StringBuilder result = new StringBuilder();

            result.Append(Title + " CallMeAgain");

            result.Append(Environment.NewLine);

            result.Append(GetLine() + transient.GetMessage());

            result.Append(Environment.NewLine);

            transient = (ITransient)serviceProvider.GetService(typeof(ITransient));

            result.Append(GetLine() + transient.GetMessage());

            result.Append(Environment.NewLine);

            return result.ToStringForClient();
        }
    }
}