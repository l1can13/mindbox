namespace ShapeLibrary
{
    /// <summary>
    /// Интерфейс, представляющий геометрическую фигуру.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Вычисляет площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double Area();

        /// <summary>
        /// Вычисляет периметр (длину границы) фигуры.
        /// </summary>
        /// <returns>Периметр фигуры.</returns>
        double Perimeter();
    }
}