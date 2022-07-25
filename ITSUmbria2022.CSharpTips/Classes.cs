namespace ITSUmbria2022.CSharpTips
{
    public class Car
    {
        public Func<string> Func;
        public Func<int, string> Func2;
        public Func<int, double, string> Func3;
        public Func<int, double, bool, string> Func4;
        public Func<int, double, bool, string> Func5;
        public string Plate { get; init; }
        public Car(string plate)
        {
            Plate = plate;
            Func = ToString;
            Func2 = Something;
            Func3 = Something;
            Func4 = (x, y, z) => string.Empty;
            Func5 = (x, y, z) =>
            {
                return string.Empty;
            };
        }
        public string Something(int x)
        {
            return string.Empty;
        }
        public string Something(int x, double t)
        {
            return string.Empty;
        }
    }
    public class Car3
    {
        public string Plate { get; init; }
    }
    public record Car2(string Plate, int Wheels, int Engine);
    public struct StructuredCar
    {
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }
        public double D { get; init; }
        public static bool operator ==(StructuredCar car1, StructuredCar car2)
        {
            return car1.Equals(car2);
        }
        public static bool operator !=(StructuredCar car1, StructuredCar car2)
        {
            return !car1.Equals(car2);
        }
    }
    public static class CarExtensions
    {
        public static bool Has4Wheels(this Car2 car)
        {
            return car.Wheels == 4;
        }
    }
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> condition)
        {
            foreach (var item in enumerable)
            {
                if (condition.Invoke(item))
                    yield return item;
            }
        }
    }
}
