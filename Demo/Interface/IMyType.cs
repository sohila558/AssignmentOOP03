using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal interface IMyType
    {
        // what can write inside the interface :
        // 1. Signature of property
        // 2. Signature of method [Name - Parameter - Return Type]
        // 3. Default implemented methods [Fully Implemented Method]


        // 2. Signature of method [Name - Parameter - Return Type]
        void MyFun();

        // 1. Signature of property
        double Salary { get; set; }

        // 3. Default implemented methods [Fully Implemented Method]
        void Print()
        {
            Console.WriteLine("Default implemented methods");
        }

    }
}
