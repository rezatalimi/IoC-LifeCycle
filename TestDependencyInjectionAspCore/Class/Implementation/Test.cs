using System;

namespace TestDependencyInjectionAspCore.Class.Implementation
{
    public abstract class Test
    {
        protected string ShowMessage { get; set; }

        protected int RandomNumber { get; set; }

        public Test(string target)
        {
            ShowMessage = target + " : Unique number for this class is ";

            var random = new Random();

            RandomNumber = random.Next(1,20);
        }

        public string GetMessage()
        {
            var result = ShowMessage + " { " + RandomNumber + " } .";

            return result;
        }
    }
}
