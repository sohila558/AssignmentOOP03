using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP03
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }

        public double Area { get { return Math.PI * Radius * Radius; } }

        public Circle(double radious)
        {
            Radius = radious;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle : Radius = {Radius}, Area = {Area}");
        }
    }
}
