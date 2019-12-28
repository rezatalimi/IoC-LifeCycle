using Microsoft.AspNetCore.Mvc;
using System;

namespace TestDependencyInjectionAspCore.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IServiceProvider serviceProvider;

        protected string Title { private set; get; }

        private int lineNumber;

        public BaseController(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;

            lineNumber = 1;

            Title = " Pipeline action : ";
        }

        protected string GetLine()
        {
            var result = " " + lineNumber + " - ";

            lineNumber++;

            return result;
        }
    }
}