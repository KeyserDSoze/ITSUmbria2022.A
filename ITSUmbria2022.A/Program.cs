using ITSUmbria2022.A.Library;

namespace ITSUmbria2022.A
{
    public class Program
    {
        public static void Main()
        {
            //IAnimalFactory animalFactory = new AnimalFactory();
            //IAnimal animal2 = animalFactory.Create(AnimalType.Cat);
            //animal2.Run();
            //animal2.Eat();
            Console.ReadLine();
            Console.WriteLine("Starting to retrieve data");
            while (true)
            {
                //SingletonClass singleton = new SingletonClass();
                //Console.WriteLine(singleton.Id);
                Console.WriteLine(SingletonClass.Instance.Id);
                Console.ReadLine();
            }
            //IAnimal cat = new Cat();
            //IAnimal dog = new Dog();
            //Cat cat2 = new Cat();

            //IAnimal animal = null;
            //animal.Run();
            //animal.Eat();
        }
    }
}