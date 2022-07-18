namespace ITSUmbria2022.Noe.Animals
{
    public abstract class Animal
    {
        public string Name { get; }
        public Animal(string name)
            => Name = name;
        public abstract void Eat();
    }
}
