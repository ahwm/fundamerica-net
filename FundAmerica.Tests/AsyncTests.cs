using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FundAmerica.Tests
{
    public class AsyncTests
    {
        // Thanks to Phil Haack
        // https://haacked.com/archive/2014/11/11/async-void-methods/
        [Fact]
        public void VerifyAsyncVoid()
        {
            Extensions.AssertNoAsyncVoidMethods(GetType().Assembly);
            Extensions.AssertNoAsyncVoidMethods(typeof(FundAmericaClient).Assembly);
        }
    }
}
