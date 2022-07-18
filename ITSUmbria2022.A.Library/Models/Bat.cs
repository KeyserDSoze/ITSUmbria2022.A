namespace ITSUmbria2022.A.Models
{
    internal class Bat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Bat eats");
        }

        public void Run()
        {
            Console.WriteLine("Bat runs");
        }
    }
}
