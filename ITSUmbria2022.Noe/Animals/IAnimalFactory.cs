namespace ITSUmbria2022.Noe.Animals
{
    public interface IAnimalFactory
    {
        Animal Census(string name, AnimalType type);
    }
}
