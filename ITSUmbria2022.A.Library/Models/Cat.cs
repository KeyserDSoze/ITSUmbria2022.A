namespace ITSUmbria2022.A.Models
{
    internal class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Cat eats");
        }

        public void Run()
        {
            Console.WriteLine("Cat runs");
        }
    }
}
