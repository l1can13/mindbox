namespace ShapeLibrary
{
    public class ShapeDemo
    {
        public static void Main(string[] args)
        {
            // Вычисление площади фигур без знания типа фигуры.
            List<IShape> shapes = new List<IShape>
            {
                new Circle(5.0),
                new Triangle(3.0, 4.0, 5.0),
                new Circle(2.0),
                new Triangle(6.0, 8.0, 10.0)
            };

            double totalArea = 0;
            foreach (var shape in shapes)
            {
                var area = shape.Area();

                Console.WriteLine("Текущая площадь равна {0}", area);

                totalArea += area;
            }

            Console.WriteLine("Общая площадь равна {0}", totalArea);
        }
    }
}