using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticHHRU
{
    public class Class1
    {
        public abstract class Shape
        {
            public abstract double CalculateArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public override double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public class Triangle : Shape
        {
            public double SideA { get; set; }
            public double SideB { get; set; }
            public double SideC { get; set; }

            public override double CalculateArea()
            {
                var p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }

            public bool IsRightTriangle()
            {
                var sides = new[] { SideA, SideB, SideC };
                Array.Sort(sides);
                return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 0.000001;
            }
        }
    }
}
