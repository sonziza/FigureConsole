using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Triangle: IFigure
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        private bool _isrectangular;
        public bool IsRectangular
        {
            get
            {
                return _isrectangular;
            }
            set { _isrectangular = SideA * SideA + SideB * SideB == SideC * SideC || false; }

        }

        public Triangle(double _sideA, double _sideB, double _sideC)
        {
            SideA = _sideA;
            SideB = _sideB;
            SideC = _sideC;
            IsRectangular = false;
        }
        public double GetSquare()
        {
            double perimeter = (SideA + SideB + SideC) / 2;
            double square = Math.Sqrt(
                perimeter * (perimeter - SideA) *
                (perimeter - SideB) *
                (perimeter - SideC));
            //см. IsRectangular
            //if (SideA * SideA + SideB * SideB == SideC * SideC)
            //    Notify?.Invoke("Этот треугольник прямоугольный");
            //else
            //    Notify?.Invoke("Этот треугольник не является прямоугольным"); 

            return square;

        }
    }
}
