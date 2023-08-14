namespace ShapeLibrary
{
    /// <summary>
    /// Класс проверок.
    /// </summary>
    public static class Validation
    {
        /// <summary>
        /// Проверяет, является ли значение отрицательным.
        /// </summary>
        /// <typeparam name="T">Тип значения.</typeparam>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="errorMessage">Сообщение об ошибке, если значение отрицательное.</param>
        public static void CheckNegative<T>(T value, string errorMessage) where T : IComparable<T>
        {
            if (Comparer<T>.Default.Compare(value, default(T)) < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), errorMessage);
            }
        }

        /// <summary>
        /// Проверяет, является ли значение null.
        /// </summary>
        /// <typeparam name="T">Тип значения.</typeparam>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="errorMessage">Сообщение об ошибке, если значение null.</param>
        public static void CheckNull<T>(T value, string errorMessage)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), errorMessage);
            }
        }
    }
}