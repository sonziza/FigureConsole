using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresLibrary.Tests
{
    [TestClass]
    public class FigureTests
    {
        private Triangle _Triangle;
        // Запускается перед стартом каждого тестирующего метода. 
        [TestInitialize]
        public void TestInitialize()
        {
            _Triangle = new Triangle(3,5,2);
        }
        /// <summary>
        /// Получить на выходе площадь 6
        /// </summary>
        [TestMethod()]
        public void GetSquare_3_4_5_Get6()
        {
            // arrange 
            _Triangle = new Triangle(3, 4, 5);
            double squareExpected = 6;

            // act 
            double square = _Triangle.GetSquare();

            //assert
            Assert.AreEqual(squareExpected, square);
        }

        /// <summary>
        /// Прямоугольный ли треугольник
        /// </summary>
        [TestMethod()]
        public void GetSquare_Straight()
        {
            // arrange 
            _Triangle = new Triangle(3, 4, 5);
            bool isRectangularExpected = true;

            Assert.AreEqual(_Triangle.IsRectangular, isRectangularExpected);

        }
    }
}

