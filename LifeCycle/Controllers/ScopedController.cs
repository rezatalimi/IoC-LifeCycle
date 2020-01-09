using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using TestDependencyInjectionAspCore.Class.Contract;

namespace TestDependencyInjectionAspCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Scoped")]
    public class ScopedController : BaseController
    {    
        public ScopedController(IServiceProvider serviceProvider) :base(serviceProvider)
        {

        }

        [HttpGet("CallMe")]
        public string CallMe()
        {
            var scoped = (IScoped)serviceProvider.GetService(typeof(IScoped));

            StringBuilder result = new StringBuilder();

            result.Append(Title + " CallMe");

            result.Append(Environment.NewLine);

            result.Append(GetLine() + scoped.GetMessage());

            result.Append(Environment.NewLine);

            scoped = (IScoped)serviceProvider.GetService(typeof(IScoped));

            result.Append(GetLine() + scoped.GetMessage());

            result.Append(Environment.NewLine);

            return result.ToStringForClient();
        }

        [HttpGet("CallMeAgain")]
        public string CallMeAgain()
        {
            var scoped = (IScoped)serviceProvider.GetService(typeof(IScoped));

            StringBuilder result = new StringBuilder();

            result.Append(Title + " CallMeAgain");

            result.Append(Environment.NewLine);

            result.Append(GetLine() + scoped.GetMessage());

            result.Append(Environment.NewLine);

            scoped = (IScoped)serviceProvider.GetService(typeof(IScoped));

            result.Append(GetLine() + scoped.GetMessage());

            result.Append(Environment.NewLine);

            return result.ToStringForClient();
        }
    }
}