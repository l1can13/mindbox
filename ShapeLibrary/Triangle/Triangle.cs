using System;

namespace ShapeLibrary
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Конструктор с параметрами - стороны треугольника.
        /// </summary>
        /// <param name="sideA">Длина первой стороны треугольника.</param>
        /// <param name="sideB">Длина второй стороны треугольника.</param>
        /// <param name="sideC">Длина третьей стороны треугольника.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Длина первой стороны треугольника.
        /// </summary>
        private double SideA { get; }

        /// <summary>
        /// Длина второй стороны треугольника.
        /// </summary>
        private double SideB { get; }

        /// <summary>
        /// Длина третьей стороны треугольника.
        /// </summary>
        private double SideC { get; }

        /// <summary>
        /// Вычисляет площадь треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double Area()
        {
            #region Валидация входных данных
            Validation.CheckNegative(SideA, LocalizableStrings.SIDE_A_NEGATIVE);
            Validation.CheckNull(SideA, LocalizableStrings.SIDE_A_NULL);

            Validation.CheckNegative(SideB, LocalizableStrings.SIDE_B_NEGATIVE);
            Validation.CheckNull(SideB, LocalizableStrings.SIDE_B_NULL);

            Validation.CheckNegative(SideC, LocalizableStrings.SIDE_C_NEGATIVE);
            Validation.CheckNull(SideC, LocalizableStrings.SIDE_C_NULL);

            if (!IsValidTriangle())
            {
                throw new ArgumentOutOfRangeException(nameof(SideA), LocalizableStrings.IRREGULAR_TRIANGLE);
            }
            #endregion

            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        /// <summary>
        /// Вычисляет периметр (сумму длин сторон) треугольника.
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
        public double Perimeter()
        {
            #region Валидация входных данных
            Validation.CheckNegative(SideA, LocalizableStrings.SIDE_A_NEGATIVE);
            Validation.CheckNull(SideA, LocalizableStrings.SIDE_A_NULL);

            Validation.CheckNegative(SideB, LocalizableStrings.SIDE_B_NEGATIVE);
            Validation.CheckNull(SideB, LocalizableStrings.SIDE_B_NULL);

            Validation.CheckNegative(SideC, LocalizableStrings.SIDE_C_NEGATIVE);
            Validation.CheckNull(SideC, LocalizableStrings.SIDE_C_NULL);

            if (!IsValidTriangle())
            {
                throw new ArgumentOutOfRangeException(nameof(SideA), LocalizableStrings.IRREGULAR_TRIANGLE);
            }
            #endregion

            return SideA + SideB + SideC;
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True, если треугольник прямоугольный. Иначе - false.</returns>
        public bool IsRightTriangle()
        {
            #region Валидация входных данных
            Validation.CheckNegative(SideA, LocalizableStrings.SIDE_A_NEGATIVE);
            Validation.CheckNull(SideA, LocalizableStrings.SIDE_A_NULL);

            Validation.CheckNegative(SideB, LocalizableStrings.SIDE_B_NEGATIVE);
            Validation.CheckNull(SideB, LocalizableStrings.SIDE_B_NULL);

            Validation.CheckNegative(SideC, LocalizableStrings.SIDE_C_NEGATIVE);
            Validation.CheckNull(SideC, LocalizableStrings.SIDE_C_NULL);

            if (!IsValidTriangle())
            {
                throw new ArgumentOutOfRangeException(nameof(SideA), LocalizableStrings.IRREGULAR_TRIANGLE);
            }
            #endregion

            double[] sides = new double[] { SideA, SideB, SideC };
            Array.Sort(sides);

            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < double.Epsilon;
        }

        /// <summary>
        /// Проверяет, удовлетворяет ли треугольник неравенству треугольника.
        /// </summary>
        /// <returns>True, если треугольник существует. Иначе - false.</returns>
        private bool IsValidTriangle()
        {
			#region Валидация входных данных
			Validation.CheckNegative(SideA, LocalizableStrings.SIDE_A_NEGATIVE);
			Validation.CheckNull(SideA, LocalizableStrings.SIDE_A_NULL);

			Validation.CheckNegative(SideB, LocalizableStrings.SIDE_B_NEGATIVE);
			Validation.CheckNull(SideB, LocalizableStrings.SIDE_B_NULL);

			Validation.CheckNegative(SideC, LocalizableStrings.SIDE_C_NEGATIVE);
			Validation.CheckNull(SideC, LocalizableStrings.SIDE_C_NULL);
			#endregion

			return
				SideA + SideB > SideC 
                && SideA + SideC > SideB 
                && SideB + SideC > SideA;
        }
    }
}