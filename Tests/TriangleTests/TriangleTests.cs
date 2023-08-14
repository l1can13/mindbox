using ShapeLibrary;

namespace TriangleTests
{
	/// <summary>
	/// ����� ��� ������ Triangle.
	/// </summary>
	[TestClass]
	public class TriangleTests
	{
		/// <summary>
		/// ���� ���������� ������� ������������ ��� ���������� ������.
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
		/// ���� ���������� ������� ������������ ��� ������������ ������ (��������� ����������).
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
		/// ���� ���������� ��������� ������������ ��� ���������� ������.
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
		/// ���� ���������� ��������� ������������ ��� ������������ ������ (��������� ����������).
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
		/// ���� ��������, �������� �� ����������� ������������� (������ ���� �������������).
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
		/// ���� ��������, �������� �� ����������� ������������� (�� ������ ���� �������������).
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