using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDependencyInjectionAspCore.Class.Contract;

namespace TestDependencyInjectionAspCore.Class.Implementation
{
    public class TestScoped :Test, IScoped
    {
        public TestScoped():base("Scoped")
        {

        }
    }
}
