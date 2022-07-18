namespace ITSUmbria2022.A.Models
{
    internal class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Dog eats");
        }

        public void Run()
        {
            Console.WriteLine("Dog runs");
        }
    }
}
