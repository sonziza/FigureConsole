using System;
using System.Collections.Generic;
using FiguresLibrary;

namespace FigureConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                                  "1. Площадь круга\n" +
                                  "2. Площадь треугольника\n" +
                                  "3. Больше углов в фигуре!");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                    {

                        Console.WriteLine("радиус?");
                        double radius = Convert.ToDouble(Console.ReadLine());

                        IFigure Figure1 = new Circle(radius);

                        Console.WriteLine($"Площадь круга: {Figure1.GetSquare()}");
                        break;
                    }
                    case "2":
                    {

                        Console.WriteLine("укажите стороны");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        Triangle Figure2 = new Triangle(a,b,c);

                        //Подключаем уведомление, является ли треугольник прямоугольным
                        Figure2.Notify += DisplayMessage;

                        Console.WriteLine($"Площадь треугольника: {Figure2.GetSquare()}");
                        if(Figure2.IsRectangular)
                        Console.WriteLine("Треугольник прямоугольный");
                        else Console.WriteLine("Треугольник не является прямоугольным");
                        break;
                    }
                    case "3":
                    {
                        SomeFigureSquare();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Неверно выбран пункт\n");
                        break;
                    }
                }
            }
        }


        //TODO: вынести в библиотеку классов
        /// <summary>
        /// Подготавливаем входные данные для расчета площади
        /// </summary>
        private static void SomeFigureSquare()
        {
            Console.WriteLine("Расчет будет по координатным точкам. \n " +
                              "Укажите количество углов");
            int angles = Convert.ToInt16(Console.ReadLine()); 
            Figure fiveangle = new Figure(angles);

            for (int i = 0; i < fiveangle.Coordinats.GetLength(0); i++)
            {
                Console.WriteLine($"{i}-я координата");
                for (int j = 0; j < 2; j++)
                {
                    int val = Convert.ToInt16(Console.ReadLine());
                    fiveangle.Coordinats[i, j] = val;
                }
            }

            double square = fiveangle.GetSquare();
            Console.WriteLine($"Площадь многоугольника равна {square}");
            Console.ReadLine();

        }


        /// <summary>
        /// Сюда будут приходить уведомлления, которые поступают в момент расчета площади фигуры
        /// </summary>
        /// <param name="msg">сообщение</param>
        private static void DisplayMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
