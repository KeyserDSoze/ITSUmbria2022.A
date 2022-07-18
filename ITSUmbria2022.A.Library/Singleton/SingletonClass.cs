namespace ITSUmbria2022.A.Library
{
    public class SingletonClass
    {
        public string Id { get; } = Guid.NewGuid().ToString();
        public static SingletonClass Instance { get; } = new SingletonClass();
        private SingletonClass()
        {
            Thread.Sleep(5000);
        }
    }
}
