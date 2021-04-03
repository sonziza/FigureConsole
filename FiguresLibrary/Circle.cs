using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Circle:IFigure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        

        public double GetSquare() => Math.PI * Math.Pow(Radius, 2);
    }
}
