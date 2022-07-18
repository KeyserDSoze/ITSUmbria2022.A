// See https://aka.ms/new-console-template for more information
using ITSUmbria2022.Noe.Animals;

List<Animal> animals = new List<Animal>();
IAnimalFactory animalFactory = new AnimalFactory();
bool nextStep = false;
do
{
    Console.WriteLine("Census the animal. Insert name.");
    string name = Console.ReadLine();
    Console.WriteLine("Insert (0) for Herbivore or (1) for Carnivore.");
    AnimalType type = (AnimalType)(int.Parse(Console.ReadLine()));
    animals.Add(animalFactory.Census(name, type));
    Console.WriteLine("Do you want to insert a new animal? (all) new animal. (but 0) feed'em all.");
    nextStep = Console.ReadLine() != "0";
} while (nextStep);

foreach (var animal in animals)
    animal.Eat();