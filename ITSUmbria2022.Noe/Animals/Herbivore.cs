namespace ITSUmbria2022.Noe.Animals
{
    public class Herbivore : Animal
    {
        public Herbivore(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating grass.");
        }
    }
}
