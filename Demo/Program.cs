using Demo.Interface;
using Demo.InterfaceEX02;

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



        }
    }
}
