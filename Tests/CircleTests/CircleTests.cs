using ShapeLibrary;

namespace CircleTests
{
	/// <summary>
	/// ����� ��� ������ Circle.
	/// </summary>
	[TestClass]
	public class CircleTests
	{
		/// <summary>
		/// ���� ���������� ������� ����� � ������������� ��������.
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
		/// ���� ���������� ������� ����� � ������������� �������� (��������� ����������).
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
		/// ���� ���������� ��������� ����� � ������������� ��������.
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
		/// ���� ���������� ��������� ����� � ������������� �������� (��������� ����������).
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