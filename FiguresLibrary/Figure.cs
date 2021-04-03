using System;
using System.Collections.Generic;
using System.Collections.Specialized;


namespace FiguresLibrary
{
    //Если пользователь не определился с типом фигуры (либо нужен быстрый расчет по параметрам), то используем этот класс
    public class Figure
    {
        public int[,] Coordinats;
        private readonly int AnglesCount;
        public Figure(int n)
        {
            AnglesCount = n;
            Coordinats = new int[AnglesCount, 2];
        }

        /// <summary>
        /// Нахождение площади многоугольника
        /// https://sovetclub.ru/kak-najti-ploshhad-mnogougolnika
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            double square = 0;
            if (Coordinats is null)
            {
                return square;
            }

            double firstSum = 0;
            double secondSum = 0;

            for (int i = 0; i < AnglesCount; i++)
            {
                //перемножаем последнюю и первую строку
                if (i == (AnglesCount - 1))
                {
                    firstSum += (Coordinats[AnglesCount - 1, 0] * Coordinats[0, 1]);
                    break;
                }
                firstSum += (Coordinats[i, 0] * Coordinats[i + 1, 1]);
            }

            for (int i = 0; i < AnglesCount; i++)
            {
                //последняя и первая строка
                if (i == (AnglesCount - 1))
                {
                    secondSum += (Coordinats[AnglesCount - 1, 1] * Coordinats[0, 0]);
                    break;
                }
                secondSum += (Coordinats[i, 1] * Coordinats[i + 1, 0]);
            }

            square = (firstSum - secondSum) / 2;
            return square;
        }


        /// <summary>
        /// Площадь прямоугольника
        /// </summary>
        /// <param name="side_a">высота</param>
        /// <param name="side_b">ширина</param>
        /// <returns></returns>
        public static double GetSquare(double side_a, double side_b) => side_a * side_b;
        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <param name="radius">радиус круга</param>
        /// <returns></returns>
        public static double GetSquare(int radius) => Math.PI * Math.Pow(radius, 2);
        /// <summary>
        /// площадь треугольника
        /// </summary>
        /// <param name="side_a">первая сторона</param>
        /// <param name="side_b">вторая сторона</param>
        /// <param name="side_c">третья сторона</param>
        /// <returns></returns>
        public static double GetSquare(double side_a, double side_b, double side_c)
        {
            double perimeter = (side_a + side_b + side_c) / 2;
            double square = Math.Sqrt(
                perimeter * (perimeter - side_a) *
                (perimeter - side_b) *
                (perimeter - side_c));
            return square;
        }
    }
}
