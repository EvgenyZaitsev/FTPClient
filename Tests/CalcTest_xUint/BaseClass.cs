using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest_xUint
{
    public class BaseClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine($"TestMethodCleanup");
        }
    }
}
