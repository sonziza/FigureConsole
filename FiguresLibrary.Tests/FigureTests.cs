using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresLibrary.Tests
{
    [TestClass]
    public class FigureTests
    {
        private Triangle _Triangle;
        // ����������� ����� ������� ������� ������������ ������. 
        [TestInitialize]
        public void TestInitialize()
        {
            _Triangle = new Triangle(3,5,2);
        }
        /// <summary>
        /// �������� �� ������ ������� 6
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
        /// ������������� �� �����������
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

