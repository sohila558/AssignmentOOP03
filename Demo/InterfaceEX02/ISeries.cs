 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterfaceEX02
{
    internal interface ISeries
    {
        public int Current { get; set; }

        void Next();
        void Reset();
    }
}
