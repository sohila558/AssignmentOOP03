using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.InterfaceEX03
{
    internal class Airplane : IMoveable, IFlyable
    {
        int IMoveable.Speed { get ; set ; }
        int IFlyable.Speed { get ; set ; }

        void IMoveable.Backward()
        {
            Console.WriteLine("Airplne IMoveable Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Airplne IFlyable Backward");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("Airplne IMoveable Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplne IFlyable Forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Airplne IMoveable Left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Airplne IFlyable Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Airplne IMoveable Right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Airplne IFlyable Right");
        }
    }
}
