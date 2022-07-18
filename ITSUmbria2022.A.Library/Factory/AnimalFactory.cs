namespace ITSUmbria2022.A.Models
{
    public interface IAnimalFactory
    {
        IAnimal Create(AnimalType type);
    }
    public class AnimalFactoryV2 : IAnimalFactory
    {
        public IAnimal Create(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Cat:
                    return new Cat();
                case AnimalType.Dog:
                    return new Dog();
                case AnimalType.Bat:
                    return new Bat();
                case AnimalType.Others:
                    return null!;
            }
            return null!;
        }
    }
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal Create(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Cat: 
                    return new Cat();
                case AnimalType.Dog:
                    return new Dog();
                case AnimalType.Bat:
                    return new Bat();
            }
            return null!;
        }
    }
}
