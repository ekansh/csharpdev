using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyTest
{
    class EntryPoint
    {
        static TestVirtualAndOverride testVirtualAndOverride = new TestVirtualAndOverride();

        static TestingRefAndOutOnPrimitiveDataType testingRefAndOutOnPrimitiveDataType = new TestingRefAndOutOnPrimitiveDataType();

        static TestAbstractionAndInterface testAbstractionAndInterface = new TestAbstractionAndInterface();
      
        static void Main(string[] args)
        {

            testAbstractionAndInterface.controller();
            System.Console.ReadLine();
        }
    }
}
