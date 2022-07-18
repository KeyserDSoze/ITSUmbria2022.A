namespace ITSUmbria2022.Noe.Animals
{
    public class Carnivore : Animal
    {
        public Carnivore(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating meat.");
        }
    }
}
