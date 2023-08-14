using ShapeLibrary;

namespace TriangleTests
{
	/// <summary>
	/// Тесты для класса Triangle.
	/// </summary>
	[TestClass]
	public class TriangleTests
	{
		/// <summary>
		/// Тест вычисления площади треугольника для корректных сторон.
		/// </summary>
		[TestMethod]
		public void TriangleArea_ValidTriangle()
		{
			double sideA = 3.0;
			double sideB = 4.0;
			double sideC = 5.0;
			Triangle triangle = new Triangle(sideA, sideB, sideC);

			double area = triangle.Area();

			Assert.AreEqual(6.0, area);
		}

		/// <summary>
		/// Тест вычисления площади треугольника для некорректных сторон (ожидается исключение).
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TriangleArea_InvalidTriangle()
		{
			double sideA = 1.0;
			double sideB = 2.0;
			double sideC = 5.0;
			Triangle triangle = new Triangle(sideA, sideB, sideC);

			double area = triangle.Area();
		}

		/// <summary>
		/// Тест вычисления периметра треугольника для корректных сторон.
		/// </summary>
		[TestMethod]
		public void TrianglePerimeter_ValidTriangle()
		{
			double sideA = 3.0;
			double sideB = 4.0;
			double sideC = 5.0;
			Triangle triangle = new Triangle(sideA, sideB, sideC);

			double perimeter = triangle.Perimeter();

			Assert.AreEqual(12.0, perimeter);
		}

		/// <summary>
		/// Тест вычисления периметра треугольника для некорректных сторон (ожидается исключение).
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TrianglePerimeter_InvalidTriangle()
		{
			double sideA = 1.0;
			double sideB = 2.0;
			double sideC = 5.0;
			Triangle triangle = new Triangle(sideA, sideB, sideC);

			double perimeter = triangle.Perimeter();
		}

		/// <summary>
		/// Тест проверки, является ли треугольник прямоугольным (должен быть прямоугольным).
		/// </summary>
		[TestMethod]
		public void TriangleIsRightTriangle_RightTriangle()
		{
			double sideA = 3.0;
			double sideB = 4.0;
			double sideC = 5.0;
			Triangle triangle = new Triangle(sideA, sideB, sideC);

			bool isRight = triangle.IsRightTriangle();

			Assert.IsTrue(isRight);
		}

		/// <summary>
		/// Тест проверки, является ли треугольник прямоугольным (не должен быть прямоугольным).
		/// </summary>
		[TestMethod]
		public void TriangleIsRightTriangle_NotRightTriangle()
		{
			double sideA = 3.0;
			double sideB = 4.0;
			double sideC = 6.0;
			Triangle triangle = new Triangle(sideA, sideB, sideC);

			bool isRight = triangle.IsRightTriangle();

			Assert.IsFalse(isRight);
		}
	}
}