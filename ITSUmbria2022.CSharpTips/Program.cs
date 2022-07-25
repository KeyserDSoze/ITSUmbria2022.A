// See https://aka.ms/new-console-template for more information
using ITSUmbria2022.CSharpTips;

Console.WriteLine("Hello, World!");
Car car = new Car("by765ou");
Car carBis = new Car("by765ou");
Car2 car2 = new Car2("uy786tr", 4, 1);
Car2 car2Bis = new Car2("uy786tr", 4, 1);
Car2 car3 = car2 with { Plate = "da435vc" };
Car3 car4 = new Car3
{
    Plate = "fr456ty"
};
StructuredCar structuredCar = new StructuredCar { A = 1, B = 2, C = 3, D = 4 };
StructuredCar structuredCar2 = new StructuredCar { A = 1, B = 2, C = 3, D = 4 };
Range range = new Range(new Index(1), new Index(2));
Range range2 = new Range(new Index(1), new Index(2));
car2.Has4Wheels();
Console.WriteLine(car);
Console.WriteLine(car2);
Console.WriteLine(car3);
Console.WriteLine(car == carBis);
Console.WriteLine(car2 == car2Bis);
Console.WriteLine(structuredCar.Equals(structuredCar2));
Console.WriteLine(range.Equals(range2));
Console.WriteLine(structuredCar == structuredCar2);
List<string> values = new() { "a", "a", "b" };
foreach (var x in values.MyWhere(x => x == "a"))
{
    Console.WriteLine(x);
}
Console.ReadKey();

