using Demo.Interface;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region InterfaceEX01

            // Interface : Reference type
            // code contract between the developer who write it and the developer who use it

            // IMytype myType = new IMyType();

            // Note : can't create object rom any interface

            //MyType myType = new MyType();
            //myType.Salary = 12000;
            //myType.MyFun();
            //Console.WriteLine(myType.Salary);

            //IMyType myType;
            // Ref ---> can refer to object from Any class which implement the interface 'IMyType'

            //myType = new MyType();

            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();
            //myType.Print();


            #endregion
        }
    }
}
