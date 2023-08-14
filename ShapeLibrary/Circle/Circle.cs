using System;

namespace ShapeLibrary
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Конструктор с параметром - радиус круга.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Радиус круга.
        /// </summary>
        private double Radius { get; }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double Area()
        {
            #region Валидация входных данных
            Validation.CheckNegative(Radius, LocalizableStrings.RADIUS_NEGATIVE);
            Validation.CheckNull(Radius, LocalizableStrings.RADIUS_NULL);
            #endregion

            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Вычисляет периметр (длину) окружности.
        /// </summary>
        /// <returns>Длина окружности.</returns>
        public double Perimeter()
        {
            #region Валидация входных данных
            Validation.CheckNegative(Radius, LocalizableStrings.RADIUS_NEGATIVE);
            Validation.CheckNull(Radius, LocalizableStrings.RADIUS_NULL);
            #endregion

            return 2 * Math.PI * Radius;
        }
    }
}