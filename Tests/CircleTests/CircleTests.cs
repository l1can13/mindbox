using ShapeLibrary;

namespace CircleTests
{
	/// <summary>
	/// Тесты для класса Circle.
	/// </summary>
	[TestClass]
	public class CircleTests
	{
		/// <summary>
		/// Тест вычисления площади круга с положительным радиусом.
		/// </summary>
		[TestMethod]
		public void CircleArea_PositiveRadius()
		{
			double radius = 5.0;
			Circle circle = new Circle(radius);

			double area = circle.Area();

			Assert.AreEqual(Math.PI * radius * radius, area);
		}

		/// <summary>
		/// Тест вычисления площади круга с отрицательным радиусом (ожидается исключение).
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void CircleArea_NegativeRadius()
		{
			double radius = -5.0;
			Circle circle = new Circle(radius);

			double area = circle.Area();
		}

		/// <summary>
		/// Тест вычисления периметра круга с положительным радиусом.
		/// </summary>
		[TestMethod]
		public void CirclePerimeter_PositiveRadius()
		{
			double radius = 5.0;
			Circle circle = new Circle(radius);

			double perimeter = circle.Perimeter();

			Assert.AreEqual(2 * Math.PI * radius, perimeter);
		}

		/// <summary>
		/// Тест вычисления периметра круга с отрицательным радиусом (ожидается исключение).
		/// </summary>
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void CirclePerimeter_NegativeRadius()
		{
			double radius = -5.0;
			Circle circle = new Circle(radius);

			double perimeter = circle.Perimeter();
		}
	}
}