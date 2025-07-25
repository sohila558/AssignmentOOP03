using Demo.Interface;
using Demo.InterfaceEX02;
using Demo.InterfaceEX03;

namespace Demo
{
    internal class Program
    {
        #region InterfaceEX02
        //static void Print10Numbers(SeriesByTow series)
        //{
        //    for(int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Numbers(SerieByThree series)
        //{
        //    for(int i = 0; i <10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}
        //static void Print10Numbers(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //}

        //static void Print10Numbers(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"{series.Current}");
        //        series.Next();
        //    }
        //    Console.WriteLine();
        //    series.Reset();
        //} 
        #endregion

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

            #region InterfaceEX02

            //SeriesByTow seriesByTow = new SeriesByTow();

            //SerieByThree seriesByThree = new SerieByThree(); 

            //SeriesByFour seriesByFour = new SeriesByFour();

            //Print10Numbers(seriesByThree);

            //int[] Numbers = { 8, 2, 7, 0, 3, 5, 6, 1 };

            //Array.Sort(Numbers);

            //foreach(int item in Numbers)
            //{
            //    Console.Write($"{item} ");
            //}

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee() {Id = 1, Name = "Ahmed", Age = 30, Salary = 12000},
            //    new Employee() {Id = 2, Name = "Omar", Age = 27, Salary = 11000},
            //    new Employee() {Id = 3, Name = "Amr", Age = 28, Salary = 13000},
            //};

            //Array.Sort(employees);

            //foreach(Employee item in employees)
            //{
            //    Console.Write($"{item}");
            //}

            #endregion

            #region InterfaceEX03
            //Car car = new Car();
            //car.Speed = 120;
            //car.Forward();

            //Airplane airplane = new Airplane();
            //IMoveable moveable = airplane;
            //moveable.Forward();

            //IFlyable flyable = airplane;
            //flyable.Forward(); 
            #endregion

            #region Shallow Copy VS Deep Copy
            // Shallow Copy VS Deep Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            // Arr01 = Arr02; // Shallow Copy
            // Copy Identity
            // { 1, 2, 3 } ---> Has Two References Arr01, Arr02
            // { 4, 5, 6 } ---> Unreachable object

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            // Identity (Address) + Object State [Data]

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);


            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr01 = (int[]) Arr02.Clone(); // Deep Copy
            //// Clone Method will Copy the object state of the caller
            //// Assign the new object to Arr02, will generate new Identity

            //// Copy Identity
            //// { 1, 2, 3 } ---> Has Two References Arr01, Arr02
            //// { 4, 5, 6 } ---> Unreachable object

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //// Identity (Address) + Object State [Data]

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); 
            #endregion

            #region IClonable
            //Employee E01 = new Employee() { Id = 1, Name = "Ahmed", Age = 30, Salary = 12000};
            //Employee E02 = new Employee() { Id = 2, Name = "Amr", Age = 32, Salary = 11000};

            //E01 = E02; // Shallow Copy
            //E01 = (Employee)E02.Clone(); // Deep Copy

            //Console.WriteLine(E01.GetHashCode);
            //Console.WriteLine(E02.GetHashCode); 
            #endregion

            #region IComparable
            //Employee[] employees = new Employee[3]
            //{
            //    new Employee() {Id = 1, Name = "Ahmed", Age = 30, Salary = 12000},
            //    new Employee() {Id = 2, Name = "Omar", Age = 27, Salary = 11000},
            //    new Employee() {Id = 3, Name = "Amr", Age = 28, Salary = 13000},
            //};

            //Array.Sort(employees);

            //int X = employees[0].CompareTo(employees[1]);
            // +ve : Caller Greater Than Parameter
            // -ve : Caller Less Than Parameter
            // 0   : Caller Equal Parameter

            //Console.WriteLine(X);


            //foreach (Employee item in employees)
            //{
            //    Console.Write($"{item}");
            //}

            #endregion

        }
    }
}
