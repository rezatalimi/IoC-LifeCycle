using System;
using System.Text;

namespace TestDependencyInjectionAspCore
{
    public static class StringBuilderExtensions
    {
        public static string ToStringForClient(this StringBuilder stringBuilder)
        {
            return stringBuilder.Replace(Environment.NewLine, "<br />").ToString();
        }
    }
}
