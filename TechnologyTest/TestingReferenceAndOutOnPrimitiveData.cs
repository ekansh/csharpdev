using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyTest
{
    class TestingRefAndOutOnPrimitiveDataType
    {
         public void controller()
        {
            int aNum = 10;
            
            //primitive values passed to the called function 
            //does not refelct any modifications that they undergo in the callee function
            System.Console.WriteLine("receiveValues----Inital value of aNum {0} after the Function call whose result was {1} the inital value becomes {2}", 
                aNum,receiveValues(aNum,aNum),aNum);

            int anOut;
            //primitive values passed to the called function by reference . Also an out parameter is also passed {second return type}
            //values that were passed by reference got updated in the callee function
            // and also we receive an out value
            System.Console.WriteLine("receivedByReference----Inital value of aNum {0} after the Function call whose result was {1} , the inital value becomes {2} and the out para is {3}",
                aNum, receivedByReference(aNum, ref aNum, out anOut), aNum, anOut);

        }
         int receiveValues(int first, int second)
        {
            int total = first + second;
            first = total;
            second = total;
            return total;
        }


         int receivedByReference(int first, ref int second, out int anotherResult)
        {
            int total = first - 5;
            anotherResult = first + second;
            second = 30;
            return total;

        }
    }
}
