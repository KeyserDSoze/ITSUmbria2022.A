namespace ITSUmbria2022.Noe.Animals
{
    public class AnimalFactory : IAnimalFactory
    {
        public Animal Census(string name, AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Herbivore:
                    return new Herbivore(name);
                case AnimalType.Carnivore:
                    return new Carnivore(name);
            }
            return null!;
        }
    }
}
